namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    // See https://schema.org/docs/actions.html#part-3
    public class AddTextTypeToActionTarget : IClassOverride
    {
        public bool CanOverride(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            return string.Equals(@class.Name, "Action", StringComparison.OrdinalIgnoreCase);
        }

        public void Override(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            var property = @class.Properties.First(x => string.Equals(x.Name, "target", StringComparison.OrdinalIgnoreCase));
            property.Types.Add(new PropertyType("URL", "Uri"));
        }
    }
}
