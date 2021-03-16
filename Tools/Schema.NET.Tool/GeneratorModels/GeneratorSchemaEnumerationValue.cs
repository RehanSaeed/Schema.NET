namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaEnumerationValue
    {
        public GeneratorSchemaEnumerationValue(Uri uri, string name)
        {
            this.Uri = uri;
            this.Name = name;
        }

        public string? Description { get; set; }

        public string Name { get; }

        public Uri Uri { get; }
    }
}
