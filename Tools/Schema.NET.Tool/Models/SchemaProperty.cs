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

        public ICollection<Uri> DomainIncludes { get; } = new List<Uri>();

        public ICollection<Uri> RangeIncludes { get; } = new List<Uri>();
    }
}
