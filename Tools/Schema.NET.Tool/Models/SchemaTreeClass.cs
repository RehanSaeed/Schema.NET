namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class SchemaTreeClass
    {
        [DataMember]
        public List<SchemaTreeClass> Children { get; set; } = new List<SchemaTreeClass>();

        [DataMember]
        public string Description { get; set; }

        [DataMember(Name = "@id")]
        public Uri Id { get; set; }

        [DataMember]
        public string Layer { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "rdfs:subClassOf")]
        public string SubClassOf { get; set; }

        [DataMember(Name = "@type")]
        public string Type { get; set; }
    }
}
