namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.ViewModels;

    public class AddQueryInputPropertyToSearchAction : IClassOverride
    {
        public bool CanOverride(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            return string.Equals(@class.Name, "SearchAction", StringComparison.Ordinal);
        }

        public void Override(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            var property = new Property()
            {
                Class = @class,
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
            @class.Properties.Add(property);
        }
    }
}
