namespace Schema.NET
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="JsonLdContext"/> object to and from JSON.
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.JsonConverter" />
    public class ContextJsonConverter : JsonConverter<JsonLdContext>
    {
        /// <inheritdoc />
        public override JsonLdContext ReadJson(JsonReader reader, Type objectType, JsonLdContext existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (objectType is null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            var context = hasExistingValue ? existingValue : new JsonLdContext();

            string name;
            string language;
            if (reader.TokenType == JsonToken.String)
            {
                name = (string)reader.Value;
                language = null;
            }
            else
            {
                var o = JObject.Load(reader);

                var nameProperty = o.Property("name", StringComparison.OrdinalIgnoreCase);
                name = nameProperty?.Value?.ToString() ?? "https://schema.org";

                var languageProperty = o.Property("@language", StringComparison.OrdinalIgnoreCase);
                language = languageProperty?.Value?.ToString();
            }

#pragma warning disable CA1062 // Validate arguments of public methods
            context.Name = name;
#pragma warning restore CA1062 // Validate arguments of public methods
            context.Language = language;
            return context;
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, JsonLdContext value, JsonSerializer serializer)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            if (string.IsNullOrWhiteSpace(value.Language))
            {
                writer.WriteValue(value.Name);
            }
            else
            {
                writer.WriteStartObject();
                writer.WritePropertyName("name");
                writer.WriteValue(value.Name);
                writer.WritePropertyName("@language");
                writer.WriteValue(value.Language);
                writer.WriteEndObject();
            }
        }
    }
}
