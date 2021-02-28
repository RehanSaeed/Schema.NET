namespace Schema.NET.Tool.GeneratorModels
{
    using System.Collections.Generic;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1724 // Identifiers should conflict with namespaces
    public class GeneratorSchemaEnumeration : GeneratorSchemaObject
#pragma warning restore CA1724 // Identifiers should conflict with namespaces
    {
        public string Description { get; set; }

        public List<GeneratorSchemaEnumerationValue> Values { get; } = new List<GeneratorSchemaEnumerationValue>();
    }
}
