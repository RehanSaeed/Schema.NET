namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="JsonLdContext"/> object to and from JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ContextJsonConverter : JsonConverter<JsonLdContext>
    {
        /// <inheritdoc />
        public override JsonLdContext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert is null)
            {
                throw new ArgumentNullException(nameof(typeToConvert));
            }

            var context = new JsonLdContext();

            string? name = null;
            string? language = null;
            if (reader.TokenType == JsonTokenType.String)
            {
                name = reader.GetString();
            }
            else
            {
                var o = JsonDocument.ParseValue(ref reader);

                if (o.RootElement.TryGetProperty("name", out var nameElement))
                {
                    name = nameElement.GetString() ?? "http://schema.org";
                }

                if (o.RootElement.TryGetProperty("@language", out var languageElement))
                {
                    language = languageElement.GetString();
                }
            }

            context.Name = name;
            context.Language = language;
            return context;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, JsonLdContext value, JsonSerializerOptions options)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrWhiteSpace(value.Language))
            {
                writer.WriteStringValue(value.Name);
            }
            else
            {
                writer.WriteStartObject();
                writer.WritePropertyName("name");
                writer.WriteStringValue(value.Name);
                writer.WritePropertyName("@language");
                writer.WriteStringValue(value.Language);
                writer.WriteEndObject();
            }
        }
    }
}
