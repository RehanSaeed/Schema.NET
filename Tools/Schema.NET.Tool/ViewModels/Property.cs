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
