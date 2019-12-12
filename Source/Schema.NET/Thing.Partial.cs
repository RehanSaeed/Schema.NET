namespace Schema.NET
{
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Thing : JsonLdObject
    {
        private const string ContextPropertyJson = "\"@context\":\"https://schema.org\",";

        /// <summary>
        /// Default serializer settings used.
        /// </summary>
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        /// <summary>
        /// Serializer settings used when trying to avoid XSS vulnerabilities where user-supplied data is used
        /// and the output of the serialization is embedded into a web page raw.
        /// </summary>
        private static readonly JsonSerializerSettings HtmlEscapedSerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml
        };
        
        
        /// <summary>
        /// Serializer settings used when deserializing.
        /// </summary>
        private static readonly JsonSerializerSettings DeserializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset,
            // The ASP.NET MVC framework defaults to 32 (so 32 levels deep in the JSON structure)
            // to prevent stack overflow caused by malicious complex JSON requests.
            MaxDepth = 32
        };

        /// <summary>
        /// Returns a strongly typed model of the JSON-LD representation provided.
        /// </summary>
        /// <typeparam name="T">Type of schema.org object to deserialize (can use Thing for any)</typeparam>
        /// <param name="str">JSON string</param>
        /// <returns>Strongly typed schema.org model</returns>
        public static T Deserialize<T>(string str) => JsonConvert.DeserializeObject<T>(str, DeserializerSettings);

        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public override string ToString() => this.ToString(SerializerSettings);

        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        ///
        /// This method should be used when you want to embed the output raw (as-is) into a web
        /// page. It uses serializer settings with HTML escaping to avoid Cross-Site Scripting (XSS)
        /// vulnerabilities if the object was constructed from an untrusted source.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public string ToHtmlEscapedString() => this.ToString(HtmlEscapedSerializerSettings);

        /// <summary>
        /// Returns the JSON-LD representation of this instance using the <see cref="JsonSerializerSettings"/> provided.
        ///
        /// Caution: You should ensure your <paramref name="serializerSettings"/> has
        /// <see cref="JsonSerializerSettings.StringEscapeHandling"/> set to <see cref="StringEscapeHandling.EscapeHtml"/>
        /// if you plan to embed the output using @Html.Raw anywhere in a web page, else you open yourself up a possible
        /// Cross-Site Scripting (XSS) attack if untrusted data is set on any of this object's properties.
        /// </summary>
        /// <param name="serializerSettings">Serialization settings.</param>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public string ToString(JsonSerializerSettings serializerSettings) =>
            RemoveAllButFirstContext(JsonConvert.SerializeObject(this, serializerSettings));

        private static string RemoveAllButFirstContext(string json)
        {
            var stringBuilder = new StringBuilder(json);
            var startIndex = ContextPropertyJson.Length + 1; // We add the one to represent the opening curly brace.
            stringBuilder.Replace(ContextPropertyJson, string.Empty, startIndex, stringBuilder.Length - startIndex);
            return stringBuilder.ToString();
        }
    }
}
