namespace Schema.NET.Tool.ViewModels
{
    using System.Collections.Generic;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1724 // Identifiers should conflict with namespaces
    public class Enumeration : SchemaObject
#pragma warning restore CA1724 // Identifiers should conflict with namespaces
    {
        public string Description { get; set; }

        public List<EnumerationValue> Values { get; } = new List<EnumerationValue>();
    }
}
