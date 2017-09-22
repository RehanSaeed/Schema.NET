namespace Schema.NET.Tool.ViewModels
{
    using System.Diagnostics;

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
