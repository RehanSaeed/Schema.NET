namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.GeneratorModels;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;

    [Generator]
    public class SchemaSourceGenerator : ISourceGenerator
    {
        private IEnumerable<GeneratorSchemaObject>? SchemaObjects { get; set; }

        public void Initialize(GeneratorInitializationContext context)
        {
            var schemaRepository = new SchemaRepository(new HttpClient()
            {
                BaseAddress = new Uri("https://schema.org"),
            });
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
                false);

#pragma warning disable VSTHRD002 // Avoid problematic synchronous waits
            this.SchemaObjects = schemaService.GetObjectsAsync().GetAwaiter().GetResult();
#pragma warning restore VSTHRD002 // Avoid problematic synchronous waits
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (this.SchemaObjects is not null)
            {
                foreach (var schemaObject in this.SchemaObjects)
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
