namespace Schema.NET
{
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Thing : JsonLdObject
    {
        private const string ContextPropertyJson = "\"@context\":\"http://schema.org\",";

        /// <summary>
        /// Serializer settings used.
        /// Note: Escapes HTML to avoid XSS vulnerabilities where user-supplied data is used.
        /// </summary>
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            NullValueHandling = NullValueHandling.Ignore,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml
        };

        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public override string ToString() =>
            RemoveAllButFirstContext(JsonConvert.SerializeObject(this, SerializerSettings));

        private static string RemoveAllButFirstContext(string json)
        {
            var stringBuilder = new StringBuilder(json);
            var startIndex = ContextPropertyJson.Length + 1; // We add the one to represent the opening curly brace.
            stringBuilder.Replace(ContextPropertyJson, string.Empty, startIndex, stringBuilder.Length - startIndex);
            return stringBuilder.ToString();
        }
    }
}
