namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Schema.NET.Tool.Constants;

    public class SchemaClass : SchemaObject
    {
        public bool IsEnum => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => x.Id == new Uri("http://schema.org/Enumeration"));

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.OrdinalIgnoreCase));

        public bool IsMeta => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Meta, StringComparison.OrdinalIgnoreCase));

        public bool IsPending => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Pending, StringComparison.OrdinalIgnoreCase));

        public bool IsPrimitive => new string[]
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
            "Quantity",
            "Mass",
            "Energy",
            "Distance",
            "Duration",
            "Time",
            "URL",
            "DataType"
        }.Contains(this.Label);

        public List<SchemaClass> SubClassOf { get; set; } = new List<SchemaClass>();

        public List<Uri> SubClassOfIds { get; set; } = new List<Uri>();
    }
}
