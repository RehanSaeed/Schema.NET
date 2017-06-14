namespace Schema.NET.Tool.Overrides
{
    using System;
    using Schema.NET.Tool.Models;

    public class WarnEmptyEnumerations : ISchemaClassOverride
    {
        public bool CanOverride(SchemaClass schemaClass) => schemaClass.IsEnum && schemaClass.Properties.Count == 0;

        public void Override(SchemaClass schemaClass)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Enumeration {schemaClass.Layer}.{schemaClass.Name} has no values");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
