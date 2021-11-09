namespace Schema.NET.Tool.CustomOverrides;

using Schema.NET.Tool.GeneratorModels;

public interface IClassOverride
{
    bool CanOverride(GeneratorSchemaClass c);

    void Override(GeneratorSchemaClass c);
}
