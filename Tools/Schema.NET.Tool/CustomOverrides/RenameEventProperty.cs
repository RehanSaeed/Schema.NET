namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.GeneratorModels;

    public class RenameEventProperty : IClassOverride
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

            return c.Properties.Any(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
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

            var eventProperty = c
                .Properties
                .First(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
            c.Properties.Remove(eventProperty);

            var updatedProperty = new GeneratorSchemaProperty(c, eventProperty.JsonName, "Events", eventProperty.Description)
            {
                Order = eventProperty.Order,
            };
            updatedProperty.Types.AddRange(eventProperty.Types);

            c.Properties.Add(updatedProperty);
        }
    }
}
