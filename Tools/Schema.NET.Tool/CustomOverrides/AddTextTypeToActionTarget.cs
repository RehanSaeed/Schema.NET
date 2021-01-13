namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    // See https://schema.org/docs/actions.html#part-3
    public class AddTextTypeToActionTarget : IClassOverride
    {
        public bool CanOverride(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return string.Equals(c.Name, "Action", StringComparison.OrdinalIgnoreCase);
        }

        public void Override(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            var property = c.Properties.First(x => string.Equals(x.Name, "target", StringComparison.OrdinalIgnoreCase));
            property.Types.Add(new PropertyType("URL", "Uri"));
        }
    }
}
