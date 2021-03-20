namespace Schema.NET.Tool.Models
{
    using System;

    public class SchemaEnumerationValue : SchemaObject
    {
        public SchemaEnumerationValue(string comment, Uri id, string label, string layer)
            : base(comment, id, label, layer)
        {
        }
    }
}
