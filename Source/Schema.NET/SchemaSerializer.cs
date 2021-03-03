namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Schema JSON Serializer
    /// </summary>
    public static class SchemaSerializer
    {
        private const string ContextPropertyJson = "\"@context\":\"https://schema.org\",";

        /// <summary>
        /// Default serializer settings used when deserializing
        /// </summary>
        private static readonly JsonSerializerSettings DeserializeSettings = new()
        {
            DateParseHandling = DateParseHandling.None,
        };

        /// <summary>
        /// Default serializer settings used when HTML escaping is not required.
        /// </summary>
        private static readonly JsonSerializerSettings DefaultSerializationSettings = new()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter(),
            },
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
        };

        /// <summary>
        /// Serializer settings used when trying to avoid XSS vulnerabilities where user-supplied data is used
        /// and the output of the serialization is embedded into a web page raw.
        /// </summary>
        private static readonly JsonSerializerSettings HtmlEscapedSerializationSettings = new()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter(),
            },
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
        };

        /// <summary>
        /// Deserializes the JSON to the specified type.
        /// </summary>
        /// <typeparam name="T">Deserialization target type</typeparam>
        /// <param name="value">JSON to deserialize</param>
        /// <returns>An instance of <typeparamref name="T"/> deserialized from JSON</returns>
        public static T DeserializeObject<T>(string value)
            => JsonConvert.DeserializeObject<T>(value, DeserializeSettings);

        /// <summary>
        /// Serializes the value to JSON with default serialization settings.
        /// </summary>
        /// <param name="value">Serialization target value</param>
        /// <returns>The serialized JSON string</returns>
        public static string SerializeObject(object value)
            => SerializeObject(value, DefaultSerializationSettings);

        /// <summary>
        /// Serializes the value to JSON with HTML escaping serialization settings.
        /// </summary>
        /// <param name="value">Serialization target value</param>
        /// <returns>The serialized JSON string</returns>
        public static string HtmlEscapedSerializeObject(object value)
            => SerializeObject(value, HtmlEscapedSerializationSettings);

        /// <summary>
        /// Serializes the value to JSON with custom serialization settings.
        /// </summary>
        /// <param name="value">Serialization target value</param>
        /// <param name="jsonSerializerSettings">JSON serialization settings</param>
        /// <returns>The serialized JSON string</returns>
        public static string SerializeObject(object value, JsonSerializerSettings jsonSerializerSettings)
            => RemoveAllButFirstContext(JsonConvert.SerializeObject(value, jsonSerializerSettings));

        private static string RemoveAllButFirstContext(string json)
        {
            if (json.IndexOf(ContextPropertyJson, StringComparison.Ordinal) != -1)
            {
                var stringBuilder = new StringBuilder(json);
                var startIndex = ContextPropertyJson.Length + 1; // We add the one to represent the opening curly brace.
                stringBuilder.Replace(ContextPropertyJson, string.Empty, startIndex, stringBuilder.Length - startIndex);
                return stringBuilder.ToString();
            }

            return json;
        }
    }
}
