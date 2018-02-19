namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    [DebuggerDisplay("{Name}")]
    public class Property : ICloneable<Property>
    {
        public Class Class { get; set; }

        public string Description { get; set; }

        public string JsonName { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<PropertyType> Types { get; set; } = new List<PropertyType>();

        public void AppendIndentLine(StringBuilder stringBuilder, int indent)
        {
            stringBuilder.AppendCommentSummary(indent, this.Description);

            var isVirtual = this
                .Class
                .Descendants
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var isOverride = this
                .Class
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var modifier = isVirtual ? " virtual" : string.Empty;
            modifier = isOverride ? " override" : modifier;

            var adjustedTypes = this.Types.Count > 1 ? $"I{this.Name}" : this.Types.First().CSharpTypeString;
            adjustedTypes = adjustedTypes.TrimEnd('?');
            var comment = this.Types.Count > 1 ? "//" + string.Join(", ", this.Types.Select(x => x.CSharpTypeString)) : string.Empty;

            var typeString = $"Values<{adjustedTypes}>?";

            stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.JsonName}\", Order = {this.Order})]");
            if (this.Types.Any(x => string.Equals(x.Name, "Duration", StringComparison.OrdinalIgnoreCase)))
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]");
            } else
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(ValuesConverter))]");
            }

            stringBuilder.AppendIndentLine(indent, $"public{modifier} {typeString} {this.Name} {{ get; set; }} {comment}");
        }

        public void AppendIndentLineInterface (StringBuilder stringBuilder, int indent)
        {
            var isOverride = this
                .Class
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            if (isOverride)
            {
                return;
            }

            stringBuilder.AppendIndentLine(indent, $"public interface I{this.Name} : IWrapper {{ }}");
            stringBuilder.AppendIndentLine(indent, $"public interface I{this.Name}<T> : I{this.Name} {{ new T Data {{ get; set; }} }}");
            foreach (var type in this.Types)
            {
                var adjustedType = type.CSharpTypeString.TrimEnd('?');
                stringBuilder.AppendIndentLine(indent, $"public class {this.Name}{adjustedType} : I{this.Name}<{adjustedType}>");
                stringBuilder.AppendIndentLine(indent, $"{{");
                stringBuilder.AppendIndentLine(indent + 4, $"object IWrapper.Data {{ get {{ return Data; }} set {{ Data = ({adjustedType}) value; }} }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public virtual {adjustedType} Data {{ get; set; }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public {this.Name}{adjustedType} () {{ }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public {this.Name}{adjustedType} ({adjustedType} data) {{ Data = data; }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public static implicit operator {this.Name}{adjustedType} ({adjustedType} data) {{ return new {this.Name}{adjustedType} (data); }}");
                stringBuilder.AppendIndentLine(indent, $"}}");
                stringBuilder.AppendLine();
            }
        }

        public Property Clone() =>
            new Property()
            {
                Description = this.Description,
                JsonName = this.JsonName,
                Name = this.Name,
                Order = this.Order,
                Types = this.Types.Select(x => x.Clone()).ToList()
            };
    }
}
