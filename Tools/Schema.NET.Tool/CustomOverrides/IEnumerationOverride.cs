namespace Schema.NET.Tool.CustomOverrides
{
    using Schema.NET.Tool.GeneratorModels;

    public interface IEnumerationOverride
    {
        bool CanOverride(GeneratorSchemaEnumeration enumeration);

        void Override(GeneratorSchemaEnumeration enumeration);
    }
}
