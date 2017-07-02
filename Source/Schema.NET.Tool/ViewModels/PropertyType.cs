using System.Diagnostics;

namespace Schema.NET.Tool.ViewModels
{
    [DebuggerDisplay("{Name} ({CSharpTypeString})")]
    public class PropertyType : ICloneable<PropertyType>
    {
        public string CSharpTypeString { get; set; }

        public string Name { get; set; }

        public PropertyType Clone() =>
            new PropertyType()
            {
                CSharpTypeString = this.CSharpTypeString,
                Name = this.Name
            };
    }
}
