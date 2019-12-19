namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    public class ExternalSchemaModelSharedNamespace : Thing
    {
        [DataMember(Name = "@type")]
        public override string Type => "ExternalSchemaModelSharedNamespace";

        [DataMember(Name = "myCustomProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MyCustomProperty { get; set; }
    }
}
