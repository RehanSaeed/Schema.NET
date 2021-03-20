namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;

    public class SchemaProperty : SchemaObject
    {
        public SchemaProperty(string comment, Uri id, string label, string layer)
            : base(comment, id, label, layer)
        {
        }

        public List<Uri> DomainIncludes { get; } = new List<Uri>();

        public List<Uri> RangeIncludes { get; } = new List<Uri>();
    }
}
