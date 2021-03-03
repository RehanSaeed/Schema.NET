namespace Schema.NET.Tool.ViewModels
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("{Name} ({CSharpTypeStrings})")]
    public class PropertyType : ICloneable<PropertyType>
    {
        public PropertyType(string name, params string[] csharpTypeStrings)
            : this(name, csharpTypeStrings.AsEnumerable())
        {
        }

        public PropertyType(string name, IEnumerable<string> csharpTypeStrings)
        {
            this.Name = name;
            this.CSharpTypeStrings = new List<string>(csharpTypeStrings);
        }

        public List<string> CSharpTypeStrings { get; }

        public string Name { get; }

        public PropertyType Clone() => new(this.Name, this.CSharpTypeStrings);
    }
}
