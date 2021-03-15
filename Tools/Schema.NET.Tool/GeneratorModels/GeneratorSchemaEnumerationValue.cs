namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaEnumerationValue
    {
        public string? Description { get; set; }

        public string? Name { get; set; }

        public Uri? Uri { get; set; }
    }
}
