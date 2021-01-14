namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.ViewModels;

    public class AddQueryInputPropertyToSearchAction : IClassOverride
    {
        public bool CanOverride(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return string.Equals(c.Name, "SearchAction", StringComparison.Ordinal);
        }

        public void Override(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            var property = new Property()
            {
                Class = c,
                Description = "Gets or sets the query input search parameter.",
                JsonName = "query-input",
                Name = "QueryInput",
            };
            property.Types.AddRange(
                new List<PropertyType>()
                {
                    new PropertyType("Text", "string"),
                    new PropertyType("PropertyValueSpecification", "PropertyValueSpecification"),
                });
            c.Properties.Add(property);
        }
    }
}
