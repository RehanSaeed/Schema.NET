namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1716 // Identifiers should not match keywords
    public class Property : ICloneable<Property>
#pragma warning restore CA1716 // Identifiers should not match keywords
    {
        public Class Class { get; set; }

        public string Description { get; set; }

        public string JsonName { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<PropertyType> Types { get; } = new List<PropertyType>();

        public string PropertyTypeString
        {
            get
            {
                var propertyTypes = this.Types.SelectMany(x => x.CSharpTypeStrings).ToArray();
                var propertyTypesString = string.Join(", ", propertyTypes);
                if (propertyTypes.Length == 1)
                {
                    return $"OneOrMany<{propertyTypesString}>";
                }
                else
                {
                    return $"Values<{propertyTypesString}>";
                }
            }
        }

        public string JsonConverterType
        {
            get
            {
                var jsonConverterType = "ValuesJsonConverter";
                if (this.Types.Any(x => string.Equals(x.Name, "Duration", StringComparison.OrdinalIgnoreCase)))
                {
                    jsonConverterType = "TimeSpanToISO8601DurationValuesJsonConverter";
                }
                else if (this.Types.Any(x => string.Equals(x.Name, "Date", StringComparison.OrdinalIgnoreCase)))
                {
                    jsonConverterType = "DateTimeToIso8601DateValuesJsonConverter";
                }

                return jsonConverterType;
            }
        }

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

            stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.JsonName}\", Order = {this.Order})]");

            if (this.Types.Any(x => string.Equals(x.Name, "Duration", StringComparison.OrdinalIgnoreCase)))
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]");
            }
            else if (this.Types.Any(x => string.Equals(x.Name, "Date", StringComparison.OrdinalIgnoreCase)))
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]");
            }
            else
            {
                stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(ValuesJsonConverter))]");
            }

            stringBuilder.AppendIndentLine(indent, $"public{modifier} {this.PropertyTypeString} {this.Name} {{ get; set; }}");
        }

        public void AppendIndentLineForInterface(StringBuilder stringBuilder, int indent)
        {
            stringBuilder.AppendCommentSummary(indent, this.Description);
            stringBuilder.AppendIndentLine(indent, $"{this.PropertyTypeString} {this.Name} {{ get; set; }}");
        }

        public Property Clone()
        {
            var property = new Property()
            {
                Description = this.Description,
                JsonName = this.JsonName,
                Name = this.Name,
                Order = this.Order,
            };
            property.Types.AddRange(this.Types.Select(x => x.Clone()));
            return property;
        }
    }
}
