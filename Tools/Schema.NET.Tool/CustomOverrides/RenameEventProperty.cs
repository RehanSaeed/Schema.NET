namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    public class RenameEventProperty : IClassOverride
    {
        public bool CanOverride(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            return @class.Properties.Any(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
        }

        public void Override(Class @class)
        {
            if (@class is null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            var eventProperty = @class
                .Properties
                .First(x => string.Equals(x.Name, "Event", StringComparison.OrdinalIgnoreCase));
            eventProperty.Name = "Events";
        }
    }
}
