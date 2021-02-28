namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.GeneratorModels;

    // https://github.com/schemaorg/schemaorg/issues/1668
    public class AddNumberTypeToMediaObjectHeightAndWidth : IClassOverride
    {
        public bool CanOverride(GeneratorSchemaClass c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return string.Equals(c.Name, "MediaObject", StringComparison.OrdinalIgnoreCase) ||
                c.CombinationOf.Any(co => string.Equals(co.Name, "MediaObject", StringComparison.OrdinalIgnoreCase));
        }

        public void Override(GeneratorSchemaClass c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            c
                .Properties
                .First(x => string.Equals(x.Name, "Height", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new GeneratorSchemaPropertyType("Integer", "int"));
            c
                .Properties
                .First(x => string.Equals(x.Name, "Width", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new GeneratorSchemaPropertyType("Integer", "int"));
        }
    }
}
