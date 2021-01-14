namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using Schema.NET.Tool.Constants;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1716 // Identifiers should not match keywords
    public class Class : SchemaObject
#pragma warning restore CA1716 // Identifiers should not match keywords
    {
        public IEnumerable<Class> Ancestors => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Where(x => x != this);

        public List<Class> Children { get; } = new List<Class>();

        public List<Class> CombinationOf { get; } = new List<Class>();

        public IEnumerable<Class> Descendants => EnumerableExtensions
            .Traverse(this, x => x.Children)
            .Where(x => x != this);

        public string Description { get; set; }

        public Uri Id { get; set; }

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.Ordinal));

        public bool IsCombined { get; set; }

        public bool IsMeta => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Meta, StringComparison.Ordinal));

        public bool IsPending => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Pending, StringComparison.Ordinal));

        public bool IsThingType => string.Equals(this.Name, "Thing", StringComparison.Ordinal);

        public List<Class> Parents { get; } = new List<Class>();

        public List<Property> Properties { get; } = new List<Property>();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            // Namespace
            stringBuilder.AppendLine("namespace Schema.NET");
            stringBuilder.AppendLine("{");

            // Using statements
            stringBuilder.AppendIndentLine(4, "using System;");
            stringBuilder.AppendIndentLine(4, "using System.Runtime.Serialization;");
            stringBuilder.AppendIndentLine(4, "using Newtonsoft.Json;");
            stringBuilder.AppendLine();

            // Comment
            stringBuilder.AppendCommentSummary(4, this.Description);

            // Interface
            stringBuilder.AppendIndent(4, $"public partial interface I{this.Name}");

            if (this.IsCombined)
            {
                stringBuilder.Append($" : ");
                stringBuilder.AppendLine(string.Join(", ", this.CombinationOf.Select(c => $"I{c.Name}")));
            }
            else if (this.Parents.Count == 0)
            {
                stringBuilder.AppendLine();
            }
            else if (this.Parents.Count == 1)
            {
                stringBuilder.Append($" : ");
                stringBuilder.AppendLine($"I{this.Parents.First().Name}");
            }
            else
            {
#pragma warning disable CA2201 // Do not raise reserved exception types
                throw new Exception(Resources.InterfaceShouldOnlyHaveOneParent);
#pragma warning restore CA2201 // Do not raise reserved exception types
            }

            stringBuilder.AppendIndentLine(4, "{");

            // Only properties that are not in ancestor or pre-combo class/interface
            if (!this.IsCombined)
            {
                var ancestorProps = this.Ancestors.SelectMany(ancestor => ancestor.Properties)
                    .Select(prop => prop.Name);
                var interfaceProperties = this.Properties.Where(classProp => !ancestorProps.Contains(classProp.Name))
                    .OrderBy(x => x.Order).ToList();
                if (interfaceProperties.Count > 0)
                {
                    var i = 0;
                    foreach (var property in interfaceProperties)
                    {
                        var isLast = i == (interfaceProperties.Count - 1);
                        property.AppendIndentLineForInterface(stringBuilder, 8);
                        if (!isLast)
                        {
                            stringBuilder.AppendLine();
                        }

                        ++i;
                    }
                }
            }

            stringBuilder.AppendIndentLine(4, "}");
            stringBuilder.AppendLine();

            // Comment
            stringBuilder.AppendCommentSummary(4, this.Description);

            // Class
            stringBuilder.AppendIndentLine(4, "[DataContract]");
            if (this.IsCombined)
            {
                stringBuilder.AppendIndent(4, $"public abstract partial class {this.Name}");
            }
            else
            {
                stringBuilder.AppendIndent(4, $"public partial class {this.Name}");
            }

            stringBuilder.Append($" : ");
            if (this.Parents.Count == 0)
            {
                stringBuilder.AppendLine($"I{this.Name}, IEquatable<{this.Name}>");
            }
            else if (this.Parents.Count == 1)
            {
                stringBuilder.AppendLine($"{this.Parents.First().Name}, I{this.Name}, IEquatable<{this.Name}>");
            }
            else
            {
#pragma warning disable CA2201 // Do not raise reserved exception types
                throw new Exception(Resources.ClassShouldOnlyHaveOneParent);
#pragma warning restore CA2201 // Do not raise reserved exception types
            }

            stringBuilder.AppendIndentLine(4, "{");

            // Type Property
            stringBuilder.AppendIndentLine(8, "/// <summary>");
            stringBuilder.AppendIndentLine(8, "/// Gets the name of the type as specified by schema.org.");
            stringBuilder.AppendIndentLine(8, "/// </summary>");
            stringBuilder.AppendIndentLine(8, "[DataMember(Name = \"@type\", Order = 1)]");
            stringBuilder.AppendIndentLine(8, $"public override string Type => \"{this.Name}\";");
            stringBuilder.AppendLine();

            // Properties
            var properties = this.Properties.OrderBy(x => x.Order).ToArray();
            foreach (var property in properties)
            {
                property.AppendIndentLine(stringBuilder, 8);
                stringBuilder.AppendLine();
            }

            // Object Equality
            stringBuilder.AppendIndentLine(8, "/// <inheritdoc/>");
            stringBuilder.AppendIndentLine(8, $"public bool Equals({this.Name} other)");
            stringBuilder.AppendIndentLine(8, "{");

            stringBuilder.AppendIndentLine(12, "if (other is null)");
            stringBuilder.AppendIndentLine(12, "{");
            stringBuilder.AppendIndentLine(16, "return false;");
            stringBuilder.AppendIndentLine(12, "}");
            stringBuilder.AppendLine();

            stringBuilder.AppendIndentLine(12, "if (ReferenceEquals(this, other))");
            stringBuilder.AppendIndentLine(12, "{");
            stringBuilder.AppendIndentLine(16, "return true;");
            stringBuilder.AppendIndentLine(12, "}");
            stringBuilder.AppendLine();

            stringBuilder.AppendIndent(12, "return this.Type == other.Type");

            foreach (var property in properties)
            {
                stringBuilder.AppendLine(" &&");
                stringBuilder.AppendIndent(16, $"this.{property.Name} == other.{property.Name}");
            }

            stringBuilder.AppendLine(" &&");
            stringBuilder.AppendIndent(16, "base.Equals(other)");

            stringBuilder.AppendLine(";");

            stringBuilder.AppendIndentLine(8, "}");
            stringBuilder.AppendLine();

            stringBuilder.AppendIndentLine(8, "/// <inheritdoc/>");
            stringBuilder.AppendIndentLine(8, $"public override bool Equals(object obj) => this.Equals(obj as {this.Name});");
            stringBuilder.AppendLine();

            stringBuilder.AppendIndentLine(8, "/// <inheritdoc/>");
            stringBuilder.AppendIndent(8, "public override int GetHashCode() => HashCode.Of(this.Type)");
            foreach (var property in properties)
            {
                stringBuilder.AppendLine();
                stringBuilder.AppendIndent(12, $".And(this.{property.Name})");
            }

            stringBuilder.AppendLine();
            stringBuilder.AppendIndent(12, $".And(base.GetHashCode())");

            stringBuilder.AppendLine(";");

            stringBuilder.AppendIndentLine(4, "}");
            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }
    }
}
