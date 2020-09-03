namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Schema.NET.Tool.Constants;

    public class SchemaClass : SchemaObject
    {
        private static readonly string[] PrimitiveTypes = new string[]
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

        public bool IsEnum => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => x.Id == new Uri("https://schema.org/Enumeration"));

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.OrdinalIgnoreCase));

        public bool IsMeta => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Meta, StringComparison.OrdinalIgnoreCase));

        public bool IsPending => EnumerableExtensions
            .Traverse(this, x => x.SubClassOf)
            .Any(x => string.Equals(x.Layer, LayerName.Pending, StringComparison.OrdinalIgnoreCase));

        public bool IsPrimitive => PrimitiveTypes.Contains(this.Label);

        public List<SchemaClass> SubClassOf { get; } = new List<SchemaClass>();

        public List<Uri> SubClassOfIds { get; } = new List<Uri>();
    }
}
