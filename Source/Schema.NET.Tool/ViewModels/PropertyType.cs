namespace Schema.NET.Tool.ViewModels
{
    using System.Collections.Generic;
    using System.Diagnostics;

    [DebuggerDisplay("{Name} ({CSharpTypeStrings})")]
    public class PropertyType : ICloneable<PropertyType>
    {
        public List<string> CSharpTypeStrings { get; set; }

        public string Name { get; set; }

        public PropertyType Clone() =>
            new PropertyType()
            {
                CSharpTypeStrings = this.CSharpTypeStrings,
                Name = this.Name
            };
    }
}
