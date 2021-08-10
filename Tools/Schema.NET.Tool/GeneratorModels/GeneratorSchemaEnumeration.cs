namespace Schema.NET.Tool.GeneratorModels
{
    using System.Collections.Generic;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaEnumeration : GeneratorSchemaObject
    {
        public GeneratorSchemaEnumeration(string layer, string name, string description)
            : base(layer, name, description)
        {
        }

        public ICollection<GeneratorSchemaEnumerationValue> Values { get; } = new List<GeneratorSchemaEnumerationValue>();
    }
}
