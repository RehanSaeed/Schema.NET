namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaEnumerationValue
    {
        public GeneratorSchemaEnumerationValue(string name, Uri uri, string description)
        {
            this.Name = name;
            this.Uri = uri;
            this.Description = description;
        }

        public string Description { get; }

        public string Name { get; }

        public Uri Uri { get; }
    }
}
