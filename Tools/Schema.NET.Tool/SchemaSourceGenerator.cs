namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;
    using Schema.NET.Tool.ViewModels;

    [Generator]
    public class SchemaSourceGenerator : ISourceGenerator
    {
        private IEnumerable<SchemaObject> SchemaObjects { get; set; }

        public void Initialize(GeneratorInitializationContext context)
        {
#pragma warning disable IDE0022 // Use expression body for methods
            Task.Run(async () =>
            {
                var schemaRepository = new SchemaRepository();
                var schemaService = new SchemaService(
                    new List<IClassOverride>()
                    {
                    new AddQueryInputPropertyToSearchAction(),
                    new AddTextTypeToActionTarget(),
                    new AddNumberTypeToMediaObjectHeightAndWidth(),
                    new RenameEventProperty(),
                    },
                    new List<IEnumerationOverride>()
                    {
                    new WarnEmptyEnumerations(),
                    },
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
                if (schemaObject is Class schemaClass)
                {
                    GenerateClass(stringBuilder, schemaClass);
                }
                else if (schemaObject is Enumeration schemaEnumeration)
                {
                    GenerateEnumeration(stringBuilder, schemaEnumeration);
                }

                context.AddSource($"{schemaObject.Name}.Generated.cs", stringBuilder.ToString());
                _ = stringBuilder.Clear();
            }
        }

        private static void GenerateClass(StringBuilder stringBuilder, Class schemaClass)
        {
            if (schemaClass.Parents.Count > 1)
            {
                throw new ArgumentException(Resources.InterfaceShouldOnlyHaveOneParent);
            }

            stringBuilder.Append($@"namespace Schema.NET
{{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

");
            var parentType = schemaClass.Parents.FirstOrDefault();

            // Add interface based on class
            stringBuilder.AppendCommentSummary(4, schemaClass.Description);

            var interfaceImplements = string.Empty;
            if (schemaClass.IsCombined)
            {
                interfaceImplements = $" : {string.Join(", ", schemaClass.CombinationOf.Select(c => $"I{c.Name}"))}";
            }
            else if (parentType is not null)
            {
                interfaceImplements = $" : I{parentType.Name}";
            }

            stringBuilder.Append($@"    public partial interface I{schemaClass.Name}{interfaceImplements}
    {{
");

            if (!schemaClass.IsCombined)
            {
                // Only declared properties belong on the interface
                foreach (var property in schemaClass.DeclaredProperties)
                {
                    stringBuilder.AppendCommentSummary(8, property.Description);
                    stringBuilder.AppendLine($@"        {property.PropertyTypeString} {property.Name} {{ get; set; }}");
                }
            }

            stringBuilder.AppendLine($@"    }}");

            // Add class
            stringBuilder.AppendCommentSummary(4, schemaClass.Description);

            var classModifiers = schemaClass.IsCombined ? " abstract" : string.Empty;
            var classImplements = parentType is not null ? $" {parentType.Name}," : string.Empty;
            var allProperties = schemaClass.Properties.OrderBy(x => x.Order).ToArray();

            stringBuilder.Append($@"    [DataContract]
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
            stringBuilder.Append($@"        /// <inheritdoc/>
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

        private static void GenerateEnumeration(StringBuilder stringBuilder, Enumeration schemaEnumeration)
        {
            stringBuilder.Append($@"namespace Schema.NET
{{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
");
            stringBuilder.AppendCommentLine(4, schemaEnumeration.Description);
            stringBuilder.Append($@"    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum {schemaEnumeration.Name}
    {{
");

            var i = 0;
            foreach (var value in schemaEnumeration.Values)
            {
                var isLast = i == (schemaEnumeration.Values.Count - 1);
                stringBuilder.AppendCommentSummary(8, value.Description);
                stringBuilder.Append($@"        [EnumMember(Value = ""{value.HttpsUri}"")]
        {value.Name},
{(isLast ? string.Empty : Environment.NewLine)}");
            }

            stringBuilder.AppendLine($@"    }}
}}");
        }

        private static void GenerateProperty(StringBuilder stringBuilder, Property schemaProperty)
        {
            stringBuilder.AppendCommentSummary(8, schemaProperty.Description);

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

            stringBuilder.Append($@"        [DataMember(Name = ""{schemaProperty.JsonName}"", Order = {schemaProperty.Order})]
        [JsonConverter(typeof({schemaProperty.JsonConverterType}))]
        public{accessModifier} {schemaProperty.PropertyTypeString} {schemaProperty.Name} {{ get; set; }}

");
        }
    }
}
