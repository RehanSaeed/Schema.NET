namespace Schema.NET.Tool.GeneratorModels;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

[DebuggerDisplay("{Name} ({CSharpTypeStrings})")]
public class GeneratorSchemaPropertyType
{
    public GeneratorSchemaPropertyType(string name, params string[] csharpTypeStrings)
        : this(name, csharpTypeStrings.AsEnumerable())
    {
    }

    public GeneratorSchemaPropertyType(string name, IEnumerable<string> csharpTypeStrings)
    {
        this.Name = name;
        this.CSharpTypeStrings = new List<string>(csharpTypeStrings);
    }

    public ICollection<string> CSharpTypeStrings { get; }

    public string Name { get; }

    public GeneratorSchemaPropertyType Clone() => new(this.Name, this.CSharpTypeStrings);
}
