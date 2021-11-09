namespace SomeCustomNamespace
{
    using System.Text.Json.Serialization;
    using Schema.NET;

    public class ExternalSchemaModelCustomNamespace : Thing
    {
        [JsonPropertyName("@type")]
        public override string Type => "ExternalSchemaModelCustomNamespace";

        [JsonPropertyName("myCustomProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MyCustomProperty { get; set; }
    }
}
