namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.Constants;

    public abstract class SchemaObject
    {
        private static readonly HashSet<string> PrimitiveTypes = new()
        {
            "QualitativeValue",
            "Enumeration",
            "Boolean",
            "Date",
            "DateTime",
            "Number",
            "Integer",
            "Float",
            "Text",
            "XPathType",
            "CssSelectorType",
            "Quantity",
            "Mass",
            "Energy",
            "Distance",
            "Duration",
            "Time",
            "URL",
            "DataType",
            "PronounceableText",
        };

        public SchemaObject(Uri id, string label, string layer)
        {
            this.Id = id;
            this.Label = label;
            this.Layer = layer;
        }

        public Uri Id { get; }

        public string Label { get; }

        public string Layer { get; }

        public string? Comment { get; set; }

        public List<string> Types { get; } = new List<string>();

        public virtual bool IsArchived => string.Equals(this.Layer, LayerName.Archived, StringComparison.OrdinalIgnoreCase);

        public virtual bool IsMeta => string.Equals(this.Layer, LayerName.Meta, StringComparison.OrdinalIgnoreCase);

        public virtual bool IsPending => string.Equals(this.Layer, LayerName.Pending, StringComparison.OrdinalIgnoreCase);

        public bool IsPrimitive => this.Label is not null && PrimitiveTypes.Contains(this.Label);
    }
}
