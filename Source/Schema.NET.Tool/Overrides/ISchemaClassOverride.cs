namespace Schema.NET.Tool.Overrides
{
    using Schema.NET.Tool.Models;

    public interface ISchemaClassOverride
    {
        bool CanOverride(SchemaClass schemaClass);

        void Override(SchemaClass schemaClass);
    }
}
