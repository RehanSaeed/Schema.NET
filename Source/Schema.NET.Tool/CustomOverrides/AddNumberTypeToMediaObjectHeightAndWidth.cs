namespace Schema.NET.Tool.CustomOverrides
{
    using System;
    using System.Collections.Generic;
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
                    CSharpTypeStrings = new List<string> { "int" },
                    Name = "Integer"
                });
            @class
                .Properties
                .First(x => string.Equals(x.Name, "Width", StringComparison.OrdinalIgnoreCase))
                .Types
                .Add(new PropertyType()
                {
                    CSharpTypeStrings = new List<string> { "int" },
                    Name = "Integer"
                });
        }
    }
}
