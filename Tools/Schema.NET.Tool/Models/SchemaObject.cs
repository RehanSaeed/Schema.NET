namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class SchemaObject
    {
        public string Comment { get; set; }

        public Uri Id { get; set; }

        public string Label { get; set; }

        public string Layer { get; set; }

        public List<string> Types { get; } = new List<string>();
    }
}
