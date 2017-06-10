using System;

namespace Schema.NET.Tool.Models
{
    public class SchemaType
    {
        public Type CSharpType { get; set; }

        public string CSharpTypeString { get; set; }

        public bool IsEnum { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
