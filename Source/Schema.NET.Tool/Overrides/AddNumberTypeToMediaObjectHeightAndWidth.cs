namespace Schema.NET.Tool.Overrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.Models;

    // https://github.com/schemaorg/schemaorg/issues/1668
    public class AddNumberTypeToMediaObjectHeightAndWidth : ISchemaClassOverride
    {
        public bool CanOverride(SchemaClass schemaClass) =>
            string.Equals(schemaClass.Name, "MediaObject", StringComparison.OrdinalIgnoreCase);

        public void Override(SchemaClass schemaClass)
        {
            var numberType = new SchemaType()
            {
                CSharpType = typeof(int),
                CSharpTypeString = "int",
                Name = "Integer",
                Url = "http://schema.org/Integer"
            };

            schemaClass
                .Properties
                .First(x => string.Equals(x.Name, "height", StringComparison.Ordinal))
                .Types
                .Add(numberType);
            schemaClass
                .Properties
                .First(x => string.Equals(x.Name, "width", StringComparison.Ordinal))
                .Types
                .Add(numberType);
        }
    }
}
