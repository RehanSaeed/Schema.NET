namespace Schema.NET.Tool.Overrides
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.Models;

    public class AddQueryInputPropertyToSearchAction : ISchemaClassOverride
    {
        public bool CanOverride(SchemaClass schemaClass) =>
            string.Equals(schemaClass.Name, "SearchAction", StringComparison.Ordinal);

        public void Override(SchemaClass schemaClass)
        {
            var schemaProperty = new SchemaProperty()
            {
                Description = "Gets or sets the query input search parameter.",
                Name = "query-input",
                PropertyType = "rdf:Property",
                Types = new List<SchemaType>()
                {
                    new SchemaType()
                    {
                        CSharpType = typeof(string),
                        CSharpTypeString = "string",
                        Name = "Text",
                        Url = "http://schema.org/Text"
                    },
                    new SchemaType()
                    {
                        CSharpTypeString = "PropertyValueSpecification",
                        Name = "PropertyValueSpecification",
                        Url = "http://schema.org/PropertyValueSpecification"
                    }
                },
                Url = "http://schema.org/query-input"
            };
            schemaClass.Properties.Add(schemaProperty);
            schemaProperty.Classes.Add(schemaClass);
            schemaProperty.ClassUrls.Add(schemaClass.Url);
        }
    }
}
