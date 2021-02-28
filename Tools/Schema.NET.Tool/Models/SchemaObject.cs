namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using Schema.NET.Tool.Constants;

    public abstract class SchemaObject
    {
        private static readonly HashSet<string> PrimitiveTypes = new HashSet<string>
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

        public string Comment { get; set; }

        public Uri Id { get; set; }

        public string Label { get; set; }

        public string Layer { get; set; }

        public List<string> Types { get; } = new List<string>();

        public virtual bool IsArchived => string.Equals(this.Layer, LayerName.Archived, StringComparison.OrdinalIgnoreCase);

        public virtual bool IsMeta => string.Equals(this.Layer, LayerName.Meta, StringComparison.OrdinalIgnoreCase);

        public virtual bool IsPending => string.Equals(this.Layer, LayerName.Pending, StringComparison.OrdinalIgnoreCase);

        public bool IsPrimitive => PrimitiveTypes.Contains(this.Label);
    }
}
