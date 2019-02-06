namespace Schema.NET.Tool.Overrides
{
    using System;
    using System.Linq;
    using Schema.NET.Tool.ViewModels;

    // https://github.com/schemaorg/schemaorg/issues/1668
    public class AddStringTypeToWebpageElementForCssSelectorAndXPath : IClassOverride
    {
        public bool CanOverride(Class @class) =>
            string.Equals(@class.Name, "WebPageElement", StringComparison.OrdinalIgnoreCase);

        public void Override(Class @class)
        {
            @class
                .Properties
                .First(x => string.Equals(x.Name, "CssSelector", StringComparison.OrdinalIgnoreCase))
                .Types[0] = new PropertyType()
                {
                    CSharpTypeString = "string",
                    Name = "String"
                };
            @class
                .Properties
                .First(x => string.Equals(x.Name, "Xpath", StringComparison.OrdinalIgnoreCase))
                .Types[0] = new PropertyType()
                {
                    CSharpTypeString = "string",
                    Name = "String"
                };
        }
    }
}
