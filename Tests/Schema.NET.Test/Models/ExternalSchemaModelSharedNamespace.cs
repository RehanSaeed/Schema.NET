namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    public class ExternalSchemaModelSharedNamespace : Thing
    {
        [DataMember(Name = "@type")]
        public override string Type => "ExternalSchemaModelSharedNamespace";

        [DataMember(Name = "myCustomProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MyCustomProperty { get; set; }
    }
}
