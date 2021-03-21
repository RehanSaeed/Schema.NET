namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;

    public class SchemaProperty : SchemaObject
    {
        public SchemaProperty(string layer, Uri id, string label, string comment)
            : base(layer, id, label, comment)
        {
        }

        public List<Uri> DomainIncludes { get; } = new List<Uri>();

        public List<Uri> RangeIncludes { get; } = new List<Uri>();
    }
}
