namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.GeneratorModels;

    public class AddQueryInputPropertyToSearchAction : IClassOverride
    {
        public bool CanOverride(GeneratorSchemaClass c)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(c);
#else
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }
#endif

            return string.Equals(c.Name, "SearchAction", StringComparison.Ordinal);
        }

        public void Override(GeneratorSchemaClass c)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(c);
#else
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }
#endif

            var property = new GeneratorSchemaProperty(c, "query-input", "QueryInput", "Gets or sets the query input search parameter.");
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
