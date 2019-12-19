namespace SomeCustomNamespace
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Schema.NET;

    public class ExternalSchemaModelCustomNamespace : Thing
    {
        [DataMember(Name = "@type")]
        public override string Type => "ExternalSchemaModelCustomNamespace";

        [DataMember(Name = "myCustomProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MyCustomProperty { get; set; }
    }
}
