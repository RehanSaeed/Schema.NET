namespace Schema.NET.Tool.Models;

using System;

public class SchemaEnumerationValue : SchemaObject
{
    public SchemaEnumerationValue(string layer, Uri id, string label, string comment)
        : base(layer, id, label, comment)
    {
    }
}
