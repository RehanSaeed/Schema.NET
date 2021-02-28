namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.GeneratorModels;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;

    [Generator]
    public class SchemaSourceGenerator : ISourceGenerator
    {
        private IEnumerable<GeneratorSchemaObject> SchemaObjects { get; set; }

        public void Initialize(GeneratorInitializationContext context)
        {
#pragma warning disable IDE0022 // Use expression body for methods
            Task.Run(async () =>
            {
                var schemaRepository = new SchemaRepository();
                var schemaService = new SchemaService(
                    new IClassOverride[]
                    {
                        new AddQueryInputPropertyToSearchAction(),
                        new AddTextTypeToActionTarget(),
                        new AddNumberTypeToMediaObjectHeightAndWidth(),
                        new RenameEventProperty(),
                    },
                    Array.Empty<IEnumerationOverride>(),
                    schemaRepository);

                this.SchemaObjects = await schemaService.GetObjectsAsync().ConfigureAwait(false);

                schemaRepository.Dispose();
#pragma warning disable VSTHRD002 // Avoid problematic synchronous waits
            }).GetAwaiter().GetResult();
#pragma warning restore IDE0022 // Use expression body for methods
#pragma warning restore VSTHRD002 // Avoid problematic synchronous waits
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var stringBuilder = new StringBuilder();

            foreach (var schemaObject in this.SchemaObjects)
            {
                if (schemaObject is GeneratorSchemaClass schemaClass)
                {
                    GenerateClass(stringBuilder, schemaClass);
                }
                else if (schemaObject is GeneratorSchemaEnumeration schemaEnumeration)
                {
                    GenerateEnumeration(stringBuilder, schemaEnumeration);
                }

                context.AddSource($"{schemaObject.Name}.Generated.cs", stringBuilder.ToString());
                _ = stringBuilder.Clear();
            }
        }

        private static void GenerateClass(StringBuilder stringBuilder, GeneratorSchemaClass schemaClass)
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

            stringBuilder.Append($@"namespace Schema.NET
{{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// {SourceUtility.RenderDoc(4, schemaClass.Description)}
    /// </summary>
    public partial interface I{schemaClass.Name}{interfaceImplements}
    {{");

            if (!schemaClass.IsCombined)
            {
                // Only declared properties belong on the interface
                foreach (var property in schemaClass.DeclaredProperties)
                {
                    stringBuilder.Append($@"
        /// <summary>
        /// {SourceUtility.RenderDoc(8, property.Description)}
        /// </summary>
        {property.PropertyTypeString} {property.Name} {{ get; set; }}
");
                }
            }

            stringBuilder.Append($@"
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
        public override string Type => ""{schemaClass.Name}"";
");

            // Add class properties
            foreach (var property in allProperties)
            {
                GenerateProperty(stringBuilder, property);
            }

            // Add object equality
            stringBuilder.Append($@"
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

            return this.Type == other.Type");

            foreach (var property in allProperties)
            {
                stringBuilder.Append($@" &&
                this.{property.Name} == other.{property.Name}");
            }

            stringBuilder.Append($@" &&
                base.Equals(other);
        }}

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as {schemaClass.Name});

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)");

            foreach (var property in allProperties)
            {
                stringBuilder.Append($@"
            .And(this.{property.Name})");
            }

            stringBuilder.AppendLine($@"
            .And(base.GetHashCode());
    }}
}}");
        }

        private static void GenerateEnumeration(StringBuilder stringBuilder, GeneratorSchemaEnumeration schemaEnumeration)
        {
            stringBuilder.Append($@"namespace Schema.NET
{{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// {SourceUtility.RenderDoc(4, schemaEnumeration.Description)}
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum {schemaEnumeration.Name}
    {{");

            foreach (var value in schemaEnumeration.Values)
            {
                stringBuilder.Append($@"
        /// <summary>
        /// {SourceUtility.RenderDoc(8, value.Description)}
        /// </summary>
        [EnumMember(Value = ""{value.HttpsUri}"")]
        {value.Name},");
            }

            stringBuilder.AppendLine($@"
    }}
}}");
        }

        private static void GenerateProperty(StringBuilder stringBuilder, GeneratorSchemaProperty schemaProperty)
        {
            // Identify access modifiers
            var isVirtual = schemaProperty
                .Class
                .Descendants
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, schemaProperty.Name, StringComparison.Ordinal)));
            var isOverride = schemaProperty
                .Class
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, schemaProperty.Name, StringComparison.Ordinal)));
            var accessModifier = isVirtual ? " virtual" : string.Empty;
            accessModifier = isOverride ? " override" : accessModifier;

            stringBuilder.Append($@"
        /// <summary>
        /// {SourceUtility.RenderDoc(8, schemaProperty.Description)}
        /// </summary>
        [DataMember(Name = ""{schemaProperty.JsonName}"", Order = {schemaProperty.Order})]
        [JsonConverter(typeof({schemaProperty.JsonConverterType}))]
        public{accessModifier} {schemaProperty.PropertyTypeString} {schemaProperty.Name} {{ get; set; }}
");
        }
    }
}
