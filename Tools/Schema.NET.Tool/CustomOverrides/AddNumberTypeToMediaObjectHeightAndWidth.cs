namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    // https://github.com/schemaorg/schemaorg/issues/1668
    public class AddNumberTypeToMediaObjectHeightAndWidth : IClassOverride
    {
        public bool CanOverride(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            return string.Equals(c.Name, "MediaObject", StringComparison.OrdinalIgnoreCase);
        }

        public void Override(Class c)
        {
            if (c is null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            c
                .Properties
                .First(x => string.Equals(x.Name, "Height", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new PropertyType("Integer", "int"));
            c
                .Properties
                .First(x => string.Equals(x.Name, "Width", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new PropertyType("Integer", "int"));
        }
    }
}
