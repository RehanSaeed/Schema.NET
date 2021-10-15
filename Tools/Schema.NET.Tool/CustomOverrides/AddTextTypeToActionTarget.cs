namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.GeneratorModels;

    // See https://schema.org/docs/actions.html#part-3
    public class AddTextTypeToActionTarget : IClassOverride
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

            return string.Equals(c.Name, "Action", StringComparison.OrdinalIgnoreCase);
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

            var property = c.Properties.First(x => string.Equals(x.Name, "target", StringComparison.OrdinalIgnoreCase));
            property.Types.Add(new GeneratorSchemaPropertyType("URL", "Uri"));
        }
    }
}
