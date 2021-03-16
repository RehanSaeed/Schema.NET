namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Schema.NET.Tool.Constants;

    public class SchemaClass : SchemaObject
    {
        private static readonly Uri EnumerationId = new("https://schema.org/Enumeration");

        public SchemaClass(Uri id, string label, string layer)
            : base(id, label, layer)
        {
        }

        public bool IsEnum => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => x.Id == EnumerationId);

        public override bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.OrdinalIgnoreCase));

        public override bool IsMeta => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Meta, StringComparison.OrdinalIgnoreCase));

        public List<SchemaClass> SubClassOf { get; } = new List<SchemaClass>();

        public List<Uri> SubClassOfIds { get; } = new List<Uri>();
    }
}
