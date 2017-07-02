namespace Schema.NET.Tool.Overrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    // https://github.com/schemaorg/schemaorg/issues/1668
    public class AddNumberTypeToMediaObjectHeightAndWidth : IClassOverride
    {
        public bool CanOverride(Class @class) =>
            string.Equals(@class.Name, "MediaObject", StringComparison.OrdinalIgnoreCase);

        public void Override(Class @class)
        {
            @class
                .Properties
                .First(x => string.Equals(x.Name, "Height", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new PropertyType()
                {
                    CSharpTypeString = "int",
                    Name = "Integer"
                });
            @class
                .Properties
                .First(x => string.Equals(x.Name, "Width", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new PropertyType()
                {
                    CSharpTypeString = "int",
                    Name = "Integer"
                });
        }
    }
}
