namespace Schema.NET.Tool
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.CodeAnalysis;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.GeneratorModels;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;

    [Generator]
    public class SchemaSourceGenerator : ISourceGenerator
    {
        private const string SchemaDataName = "Schema.NET.Tool.Data.schemaorg-all-https.jsonld";

        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var schemaDataStream = Assembly
                .GetExecutingAssembly()
                .GetManifestResourceStream(SchemaDataName);
            if (schemaDataStream == null)
            {
                throw new InvalidOperationException($"Schema data file '{SchemaDataName}' not found.");
            }

            var schemaRepository = new SchemaRepository(schemaDataStream);
            var schemaService = new SchemaService(
                new IClassOverride[]
                {
                    new AddQueryInputPropertyToSearchAction(),
                    new AddTextTypeToActionTarget(),
                    new AddNumberTypeToMediaObjectHeightAndWidth(),
                    new RenameEventProperty(),
                },
                Array.Empty<IEnumerationOverride>(),
                schemaRepository,
                IncludePendingSchemaObjects(context));

#pragma warning disable VSTHRD002 // Avoid problematic synchronous waits
            var schemaObjects = schemaService.GetObjectsAsync().GetAwaiter().GetResult();
#pragma warning restore VSTHRD002 // Avoid problematic synchronous waits

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

        private static bool IncludePendingSchemaObjects(GeneratorExecutionContext context)
        {
            var configuration = context.AnalyzerConfigOptions.GlobalOptions;
            return configuration.TryGetValue($"build_property.IncludePendingSchemaObjects", out var value) &&
                value.Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1513:Closing brace should be followed by blank line", Justification = "Interpolated string")]
        private static string RenderClass(GeneratorSchemaClass schemaClass)
        {
            if (schemaClass.Parents.Count > 1)
            {
                throw new ArgumentException(Resources.InterfaceShouldOnlyHaveOneParent);
            }

            var parentType = schemaClass.Parents.FirstOrDefault();

            var interfaceImplements = string.Empty;
            if (schemaClass.IsCombined)
            {
                interfaceImplements = $" : {string.Join(", ", schemaClass.CombinationOf.Select(c => $"I{c.Name}"))}";
            }
            else if (parentType is not null)
            {
                interfaceImplements = $" : I{parentType.Name}";
            }

            var classModifiers = schemaClass.IsCombined ? " abstract" : string.Empty;
            var classImplements = parentType is not null ? $" {parentType.Name}," : string.Empty;
            var allProperties = schemaClass.Properties.OrderBy(x => x.Order).ToArray();

            return
$@"namespace Schema.NET
{{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// {SourceUtility.RenderDoc(4, schemaClass.Description)}
    /// </summary>
    public partial interface I{schemaClass.Name}{interfaceImplements}
    {{{SourceUtility.RenderItems(!schemaClass.IsCombined, schemaClass.DeclaredProperties, property => $@"
        /// <summary>
        /// {SourceUtility.RenderDoc(8, property.Description)}
        /// </summary>
        {property.PropertyTypeString} {property.Name} {{ get; set; }}")}
    }}

    /// <summary>
    /// {SourceUtility.RenderDoc(4, schemaClass.Description)}
    /// </summary>
    [DataContract]
    public{classModifiers} partial class {schemaClass.Name} :{classImplements} I{schemaClass.Name}, IEquatable<{schemaClass.Name}>
    {{
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = ""@type"", Order = 1)]
        public override string Type => ""{schemaClass.Name}"";{SourceUtility.RenderItems(allProperties, property => $@"

        /// <summary>
        /// {SourceUtility.RenderDoc(8, property.Description)}
        /// </summary>
        [DataMember(Name = ""{property.JsonName}"", Order = {property.Order})]
        [JsonConverter(typeof({property.JsonConverterType}))]
        public{GetAccessModifier(property)} {property.PropertyTypeString} {property.Name} {{ get; set; }}")}

        /// <inheritdoc/>
        public override bool TrySetValue(string property, IEnumerable<object> value)
        {{
            if (string.IsNullOrWhiteSpace(property))
            {{
                return false;
            }}

            var success = false;
            {SourceUtility.RenderItems(allProperties, property => $@"if (""{property.Name}"".Equals(property, StringComparison.OrdinalIgnoreCase))
            {{
                this.{property.Name} = new(value);
                success = true;
            }}
            else ")}
            {{
                success = base.TrySetValue(property, value);
            }}

            return success;
        }}

        /// <inheritdoc/>
        public override bool TryGetValue<TValue>(string property, out OneOrMany<TValue> result)
        {{
            if (string.IsNullOrWhiteSpace(property))
            {{
                result = default;
                return false;
            }}

            var success = false;
            {SourceUtility.RenderItems(allProperties, property => $@"if (""{property.Name}"".Equals(property, StringComparison.OrdinalIgnoreCase))
            {{
                {SourceUtility.RenderItems(property.CSharpTypes, (propertyType, index) => $@"if (typeof({propertyType}) == typeof(TValue))
                {{
                    result = (OneOrMany<TValue>)(IValues)this.{property.Name}{(property.CSharpTypes.Count() > 1 ? $".Value{index + 1}" : string.Empty)};
                    success = true;
                }}
                else ")}
                {{
                    result = default;
                }}
            }}
            else ")}
            {{
                success = base.TryGetValue(property, out result);
            }}

            return success;
        }}

        /// <inheritdoc/>
        public override bool TryGetValue(string property, out IValues result)
        {{
            if (string.IsNullOrWhiteSpace(property))
            {{
                result = default;
                return false;
            }}

            var success = false;
            {SourceUtility.RenderItems(allProperties, property => $@"if (""{property.Name}"".Equals(property, StringComparison.OrdinalIgnoreCase))
            {{
                result = (IValues)this.{property.Name};
                success = true;
            }}
            else ")}
            {{
                success = base.TryGetValue(property, out result);
            }}

            return success;
        }}

        /// <inheritdoc/>
        public bool Equals({schemaClass.Name} other)
        {{
            if (other is null)
            {{
                return false;
            }}

            if (ReferenceEquals(this, other))
            {{
                return true;
            }}

            return this.Type == other.Type{SourceUtility.RenderItems(allProperties, property => $@" &&
                this.{property.Name} == other.{property.Name}")} &&
                base.Equals(other);
        }}

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as {schemaClass.Name});

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type){SourceUtility.RenderItems(allProperties, property => $@"
            .And(this.{property.Name})")}
            .And(base.GetHashCode());
    }}
}}";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1513:Closing brace should be followed by blank line", Justification = "Interpolated string")]
        private static string RenderEnumeration(GeneratorSchemaEnumeration schemaEnumeration) =>
$@"namespace Schema.NET
{{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// {SourceUtility.RenderDoc(4, schemaEnumeration.Description)}
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum {schemaEnumeration.Name}
    {{{SourceUtility.RenderItems(schemaEnumeration.Values, value => $@"
        /// <summary>
        /// {SourceUtility.RenderDoc(8, value.Description)}
        /// </summary>
        [EnumMember(Value = ""{value.Uri}"")]
        {value.Name},")}
    }}
}}";

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
}
