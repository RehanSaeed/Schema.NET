namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.GeneratorModels;

    public class AddQueryInputPropertyToSearchAction : IClassOverride
    {
        public bool CanOverride(GeneratorSchemaClass c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return string.Equals(c.Name, "SearchAction", StringComparison.Ordinal);
        }

        public void Override(GeneratorSchemaClass c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            var property = new GeneratorSchemaProperty()
            {
                Class = c,
                Description = "Gets or sets the query input search parameter.",
                JsonName = "query-input",
                Name = "QueryInput",
            };
            property.Types.AddRange(
                new List<GeneratorSchemaPropertyType>()
                {
                    new GeneratorSchemaPropertyType("Text", "string"),
                    new GeneratorSchemaPropertyType("PropertyValueSpecification", "PropertyValueSpecification"),
                });
            c.Properties.Add(property);
        }
    }
}
