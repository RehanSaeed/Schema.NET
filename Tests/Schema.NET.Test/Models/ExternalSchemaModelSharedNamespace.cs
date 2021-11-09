namespace Schema.NET;

using System.Text.Json.Serialization;

public class ExternalSchemaModelSharedNamespace : Thing
{
    [JsonPropertyName("@type")]
    public override string Type => "ExternalSchemaModelSharedNamespace";

    [JsonPropertyName("myCustomProperty")]
    [JsonConverter(typeof(ValuesJsonConverter))]
    public OneOrMany<string> MyCustomProperty { get; set; }
}
