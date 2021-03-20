namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaEnumerationValue
    {
        public GeneratorSchemaEnumerationValue(string name, Uri uri)
        {
            this.Name = name;
            this.Uri = uri;
        }

        public string? Description { get; set; }

        public string Name { get; }

        public Uri Uri { get; }
    }
}
