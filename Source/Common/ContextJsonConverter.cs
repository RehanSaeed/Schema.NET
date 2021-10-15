namespace Schema.NET
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="JsonLdContext"/> object to and from JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ContextJsonConverter : JsonConverter<JsonLdContext>
    {
        /// <inheritdoc />
        public override JsonLdContext ReadJson(JsonReader reader, Type objectType, JsonLdContext? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(reader);
            ArgumentNullException.ThrowIfNull(objectType);
            if (hasExistingValue)
            {
                ArgumentNullException.ThrowIfNull(existingValue);
            }

            ArgumentNullException.ThrowIfNull(serializer);
#else
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (objectType is null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            if (hasExistingValue && existingValue is null)
            {
                throw new ArgumentNullException(nameof(existingValue));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }
#endif

            var context = hasExistingValue ? existingValue! : new JsonLdContext();

            string? name;
            string? language;
            if (reader.TokenType == JsonToken.String)
            {
                name = (string?)reader.Value;
                language = null;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                var o = JObject.Load(reader);

                var nameProperty = o.Property("name", StringComparison.OrdinalIgnoreCase);
                name = nameProperty?.Value?.ToString() ?? "https://schema.org";

                var languageProperty = o.Property("@language", StringComparison.OrdinalIgnoreCase);
                language = languageProperty?.Value?.ToString();
            }
            else
            {
                var a = JArray.Load(reader);

                name = language = null;
                foreach (var entry in a)
                {
                    if (entry.Type == JTokenType.String)
                    {
                        name ??= (string?)entry;
                    }
                    else
                    {
                        var o = (JObject)entry;

                        var nameProperty = o.Property("name", StringComparison.OrdinalIgnoreCase);
                        name ??= nameProperty?.Value?.ToString() ?? "https://schema.org";

                        var languageProperty = o.Property("@language", StringComparison.OrdinalIgnoreCase);
                        language ??= languageProperty?.Value?.ToString();
                    }
                }
            }

#pragma warning disable CA1062 // Validate arguments of public methods
            context.Name = name;
            context.Language = language;
#pragma warning restore CA1062 // Validate arguments of public methods
            return context;
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, JsonLdContext? value, JsonSerializer serializer)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(writer);
            ArgumentNullException.ThrowIfNull(value);
            ArgumentNullException.ThrowIfNull(serializer);
#else
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
#endif

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
