namespace Schema.NET.Tool.GeneratorModels;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

[DebuggerDisplay("{Name}")]
public class GeneratorSchemaProperty
{
    public GeneratorSchemaProperty(GeneratorSchemaClass @class, string jsonName, string name, string description)
    {
        this.Class = @class;
        this.JsonName = jsonName;
        this.Name = name;
        this.Description = description;
    }

    public GeneratorSchemaClass Class { get; }

    public string Description { get; }

    public string JsonName { get; }

    public string Name { get; }

    public int Order { get; set; }

    public ICollection<GeneratorSchemaPropertyType> Types { get; } = new List<GeneratorSchemaPropertyType>();

    public ICollection<string> CSharpTypes => this.Types.SelectMany(x => x.CSharpTypeStrings).ToList();

    public string PropertyTypeString
    {
        get
        {
            var propertyTypes = this.CSharpTypes.ToArray();
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

    public GeneratorSchemaProperty Clone(GeneratorSchemaClass context)
    {
        var property = new GeneratorSchemaProperty(context, this.JsonName, this.Name, this.Description)
        {
            Order = this.Order,
        };
        property.Types.AddRange(this.Types.Select(x => x.Clone()));
        return property;
    }
}
