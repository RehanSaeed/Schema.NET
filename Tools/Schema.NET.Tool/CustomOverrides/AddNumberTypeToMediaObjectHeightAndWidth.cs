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
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(items);
#else
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }
#endif

            return string.Equals(c.Name, "MediaObject", StringComparison.OrdinalIgnoreCase) ||
                c.CombinationOf.Any(co => string.Equals(co.Name, "MediaObject", StringComparison.OrdinalIgnoreCase));
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
