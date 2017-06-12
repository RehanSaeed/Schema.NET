namespace Schema.NET.Tool.Overrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.Models;

    // See https://schema.org/docs/actions.html#part-3
    public class AddTextTypeToActionTarget : ISchemaClassOverride
    {
        public bool CanOverride(SchemaClass schemaClass) =>
            string.Equals(schemaClass.Name, "Action", StringComparison.OrdinalIgnoreCase);

        public void Override(SchemaClass schemaClass)
        {
            var property = schemaClass.Properties.First(x => string.Equals(x.Name, "target", StringComparison.Ordinal));
            property.Types.Add(
                new SchemaType()
                {
                    CSharpType = typeof(Uri),
                    CSharpTypeString = "Uri",
                    Name = "URL",
                    Url = "http://schema.org/URL"
                });
        }
    }
}
