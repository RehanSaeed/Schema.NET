namespace Schema.NET.Tool;

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Schema.NET.Tool.CustomOverrides;
using Schema.NET.Tool.GeneratorModels;
using Schema.NET.Tool.Repositories;
using Schema.NET.Tool.Services;

[Generator]
public class SchemaSourceGenerator : IIncrementalGenerator
{
    private const string SchemaDataName = "schemaorg-all-https.jsonld";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var schemaJsonLdDataFile = context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(SchemaDataName, StringComparison.OrdinalIgnoreCase))
            .Collect();

        var configuration = context.AnalyzerConfigOptionsProvider
            .Select((provider, _) => provider.GlobalOptions);

        context.RegisterSourceOutput(configuration.Combine(schemaJsonLdDataFile), Generate);
    }

    private static void Generate(SourceProductionContext context, (AnalyzerConfigOptions Options, ImmutableArray<AdditionalText> AdditionalText) data)
    {
        var schemaJsonLdDataFile = data.AdditionalText.SingleOrDefault() ??
            throw new InvalidOperationException($"Schema data file '{SchemaDataName}' not configured.");

        var schemaJsonLdData = schemaJsonLdDataFile.GetText(context.CancellationToken) ??
            throw new InvalidOperationException($"Unable to read schema data file '{SchemaDataName}'.");

        var schemaRepository = new SchemaRepository(schemaJsonLdData);
        var schemaService = new SchemaService(
            new IClassOverride[]
            {
                new AddQueryInputPropertyToSearchAction(),
                new AddNumberTypeToMediaObjectHeightAndWidth(),
                new RenameEventProperty(),
            },
            Array.Empty<IEnumerationOverride>(),
            schemaRepository,
            IncludePendingSchemaObjects(data.Options));

        var schemaObjects = schemaService.GetObjects();
        if (schemaObjects is not null)
        {
            foreach (var schemaObject in schemaObjects)
            {
                var source = string.Empty;
                if (schemaObject is GeneratorSchemaClass schemaClass)
                {
                    source = RenderClass(schemaClass);
                }
                else if (schemaObject is GeneratorSchemaEnumeration schemaEnumeration)
                {
                    source = RenderEnumeration(schemaEnumeration);
                }

                context.AddSource($"{schemaObject.Layer}.{schemaObject.Name}.Generated.cs", source);
            }
        }
    }

    private static bool IncludePendingSchemaObjects(AnalyzerConfigOptions options) =>
        options.TryGetValue($"build_property.IncludePendingSchemaObjects", out var value) &&
            value.Equals("true", StringComparison.OrdinalIgnoreCase);

    private static string RenderClass(GeneratorSchemaClass schemaClass)
    {
        if (schemaClass.Parents.Count > 1)
        {
            throw new ArgumentException(Resources.InterfaceShouldOnlyHaveOneParent);
        }

        var parentType = schemaClass.Parents.FirstOrDefault();

        var classModifiers = schemaClass.IsCombined ? " abstract" : string.Empty;
        var classImplements = parentType is not null ? $" {parentType.Name}," : string.Empty;
        var allProperties = schemaClass.Properties.OrderBy(x => x.Order).ToArray();

        return
            $$"""
            #nullable enable
            namespace Schema.NET;

            using System;
            using System.Collections.Generic;
            using System.Text.Json;
            using System.Text.Json.Serialization;

            {{RenderInterface(schemaClass, parentType)}}

            /// <summary>
            /// {{SourceUtility.RenderDoc(4, schemaClass.Description)}}
            /// </summary>
            public{{classModifiers}} partial class {{schemaClass.Name}} :{{classImplements}} I{{schemaClass.Name}}, IEquatable<{{schemaClass.Name}}>
            {
                /// <summary>
                /// Gets the name of the type as specified by schema.org.
                /// </summary>
                [JsonPropertyName("@type")]
                [JsonPropertyOrder(1)]
                public override string Type => "{{schemaClass.Name}}";

            {{SourceUtility.RenderItems(allProperties, RenderClassProperty, 4, SourceDelimeter.NewLineSpace)}}

            {{RenderClassTrySetValue(allProperties, 4)}}

            {{RenderClassTryGetVaueOneOrMany(allProperties, 4)}}

            {{RenderClassTryGetVaueIValues(allProperties, 4)}}

            {{RenderClassEquals(schemaClass, allProperties, 4)}}

                /// <inheritdoc/>
                public override bool Equals(object? obj) => this.Equals(obj as {{schemaClass.Name}});

                /// <inheritdoc/>
                public override int GetHashCode() => HashCode.Of(this.Type){{SourceUtility.RenderItems(allProperties, (index, indent, property) => $@"
                    .And(this.{property.Name})")}}
                    .And(base.GetHashCode());
            }
            """;
    }

    private static string RenderInterface(GeneratorSchemaClass schemaClass, GeneratorSchemaClass? parentType)
    {
        var interfaceImplements = string.Empty;
        if (schemaClass.IsCombined)
        {
            interfaceImplements = $" : {string.Join(", ", schemaClass.CombinationOf.Select(c => $"I{c.Name}"))}";
        }
        else if (parentType is not null)
        {
            interfaceImplements = $" : I{parentType.Name}";
        }

        return
            $$"""
            /// <summary>
            /// {{SourceUtility.RenderDoc(4, schemaClass.Description)}}
            /// </summary>
            public partial interface I{{schemaClass.Name}}{{interfaceImplements}}
            {
            {{SourceUtility.RenderItems(!schemaClass.IsCombined, schemaClass.DeclaredProperties, RenderInterfaceProperty, 4, SourceDelimeter.NewLineSpace)}}
            }
            """;
    }

    private static string RenderInterfaceProperty(int index, int indent, GeneratorSchemaProperty property) =>
        $$"""
        /// <summary>
        /// {{SourceUtility.RenderDoc(indent + 4, property.Description)}}
        /// </summary>
        {{property.PropertyTypeString}} {{property.Name}} { get; set; }
        """;

    private static string RenderClassProperty(int index, int indent, GeneratorSchemaProperty property) =>
        $$"""
        /// <summary>
        /// {{SourceUtility.RenderDoc(indent + 4, property.Description)}}
        /// </summary>
        [JsonPropertyName("{{property.JsonName}}")]
        [JsonPropertyOrder({{property.Order}})]
        [JsonConverter(typeof({{property.JsonConverterType}}))]
        public{{GetAccessModifier(property)}} {{property.PropertyTypeString}} {{property.Name}} { get; set; }
        """;

    private static string RenderClassTrySetValue(GeneratorSchemaProperty[] allProperties, int indent)
    {
        if (allProperties.Length == 0)
        {
            return SourceUtility.Render(
                """
                /// <inheritdoc/>
                public override bool TrySetValue(string property, IEnumerable<object> value)
                {
                    if (string.IsNullOrWhiteSpace(property))
                    {
                        return false;
                    }

                    return base.TrySetValue(property, value);
                }
                """,
                indent);
        }

        var conditions = SourceUtility.RenderItems(
            allProperties,
            (index, indent, property) =>
            $$"""
            {{(index == 0 ? "if" : "else if")}} ("{{property.Name}}".Equals(property, StringComparison.OrdinalIgnoreCase))
            {
                this.{{property.Name}} = new(value);
                success = true;
            }
            """,
            indent,
            SourceDelimeter.NewLine);

        return SourceUtility.Render(
            $$"""
            /// <inheritdoc/>
            public override bool TrySetValue(string property, IEnumerable<object> value)
            {
                if (string.IsNullOrWhiteSpace(property))
                {
                    return false;
                }

                bool success;
            {{conditions}}
                else
                {
                    success = base.TrySetValue(property, value);
                }

                return success;
            }
            """,
            indent);
    }

    private static string RenderClassTryGetVaueOneOrMany(GeneratorSchemaProperty[] allProperties, int indent)
    {
        if (allProperties.Length == 0)
        {
            return SourceUtility.Render(
                """
                /// <inheritdoc/>
                public override bool TryGetValue<TValue>(string property, out OneOrMany<TValue> result)
                {
                    if (string.IsNullOrWhiteSpace(property))
                    {
                        result = default;
                        return false;
                    }

                    return base.TryGetValue(property, out result);
                }
                """,
                indent);
        }

        var conditions = SourceUtility.RenderItems(
            allProperties,
            (index, indent, property) =>
            $$"""
            {{(index == 0 ? "if" : "else if")}} ("{{property.Name}}".Equals(property, StringComparison.OrdinalIgnoreCase))
            {
            {{SourceUtility.RenderItems(
                property.CSharpTypes,
                (index, indent, propertyType) =>
                $$"""
                {{(index == 0 ? "if" : "else if")}} (typeof({{propertyType}}) == typeof(TValue))
                {
                    result = (OneOrMany<TValue>)(IValues)this.{{property.Name}}{{(property.CSharpTypes.Count > 1 ? $".Value{index + 1}" : string.Empty)}};
                    success = true;
                }
                """,
                indent)}}
                else
                {
                    result = default;
                }
            }
            """,
            indent,
            SourceDelimeter.NewLine);

        return SourceUtility.Render(
            $$"""
            /// <inheritdoc/>
            public override bool TryGetValue<TValue>(string property, out OneOrMany<TValue> result)
            {
                if (string.IsNullOrWhiteSpace(property))
                {
                    result = default;
                    return false;
                }

                var success = false;
            {{conditions}}
                else
                {
                    success = base.TryGetValue(property, out result);
                }

                return success;
            }
            """,
            indent);
    }

    private static string RenderClassTryGetVaueIValues(GeneratorSchemaProperty[] allProperties, int indent)
    {
        if (allProperties.Length == 0)
        {
            return SourceUtility.Render(
                """
                /// <inheritdoc/>
                public override bool TryGetValue(string property, out IValues? result)
                {
                    if (string.IsNullOrWhiteSpace(property))
                    {
                        result = default;
                        return false;
                    }

                    return base.TryGetValue(property, out result);
                }
                """,
                indent);
        }

        var conditions = SourceUtility.RenderItems(
            allProperties,
            (index, indent, property) =>
            $$"""
            {{(index == 0 ? "if" : "else if")}} ("{{property.Name}}".Equals(property, StringComparison.OrdinalIgnoreCase))
            {
                result = this.{{property.Name}};
                success = true;
            }
            """,
            indent,
            SourceDelimeter.NewLine);

        return SourceUtility.Render(
            $$"""
            /// <inheritdoc/>
            public override bool TryGetValue(string property, out IValues? result)
            {
                if (string.IsNullOrWhiteSpace(property))
                {
                    result = default;
                    return false;
                }

                bool success;
            {{conditions}}
                else
                {
                    success = base.TryGetValue(property, out result);
                }

                return success;
            }
            """,
            indent);
    }

    private static string RenderClassEquals(GeneratorSchemaClass schemaClass, GeneratorSchemaProperty[] allProperties, int indent) =>
        SourceUtility.Render(
            $$"""
            /// <inheritdoc/>
            public bool Equals({{schemaClass.Name}}? other)
            {
                if (other is null)
                {
                    return false;
                }

                if (ReferenceEquals(this, other))
                {
                    return true;
                }

                return this.Type == other.Type{{SourceUtility.RenderItems(allProperties, (index, indent, property) => $@" &&
                    this.{property.Name} == other.{property.Name}")}} &&
                    base.Equals(other);
            }
            """,
            indent);

    private static string RenderEnumeration(GeneratorSchemaEnumeration schemaEnumeration) =>
        $$"""
        #nullable enable
        namespace Schema.NET;

        using System.Runtime.Serialization;
        using System.Text.Json.Serialization;

        /// <summary>
        /// {{SourceUtility.RenderDoc(4, schemaEnumeration.Description)}}
        /// </summary>
        [JsonConverter(typeof(SchemaEnumJsonConverter<{{schemaEnumeration.Name}}>))]
        public enum {{schemaEnumeration.Name}}
        {
        {{SourceUtility.RenderItems(schemaEnumeration.Values.ToArray(), RenderEnumerationValue, 4, SourceDelimeter.NewLineSpace)}}
        }
        """;

    private static string RenderEnumerationValue(int index, int indent, GeneratorSchemaEnumerationValue value) =>
        $"""
        /// <summary>
        /// {SourceUtility.RenderDoc(indent + 4, value.Description)}
        /// </summary>
        [EnumMember(Value = "{value.Uri}")]
        {value.Name},
        """;

    private static string GetAccessModifier(GeneratorSchemaProperty schemaProperty)
    {
        var isOverride = schemaProperty.Class is not null && schemaProperty
            .Class
            .Ancestors
            .Any(x => x.Properties.Any(y => string.Equals(y.Name, schemaProperty.Name, StringComparison.Ordinal)));
        if (isOverride)
        {
            return " override";
        }

        var isVirtual = schemaProperty.Class is not null && schemaProperty
            .Class
            .Descendants
            .Any(x => x.Properties.Any(y => string.Equals(y.Name, schemaProperty.Name, StringComparison.Ordinal)));
        if (isVirtual)
        {
            return " virtual";
        }

        return string.Empty;
    }
}
