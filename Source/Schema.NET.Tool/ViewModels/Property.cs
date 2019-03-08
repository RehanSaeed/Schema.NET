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

            var adjustedTypes = string.Join(", ", this.Types.Select(x => x.CSharpTypeString));
            var rootType = this.Types.Count == 1 ? "OneOrMany" : "Values";
            var typeString = $"{rootType}<{adjustedTypes}>";

            stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.JsonName}\", Order = {this.Order})]");

            if (this.Types.Any(x => string.Equals(x.Name, "Duration", StringComparison.OrdinalIgnoreCase)))
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]");
            }
            else
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(ValuesConverter))]");
            }

            stringBuilder.AppendIndentLine(indent, $"public{modifier} {typeString} {this.Name} {{ get; set; }}");
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
