namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    public class RenameEventProperty : IClassOverride
    {
        public bool CanOverride(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return c.Properties.Any(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
        }

        public void Override(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            var eventProperty = c
                .Properties
                .First(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
            eventProperty.Name = "Events";
        }
    }
}
