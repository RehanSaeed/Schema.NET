using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Schema.NET
{
    [JsonConverter(typeof(ThingConverter))]
    public partial class Thing : JsonLdObject
    {
        private const string ContextPropertyJson = "\"@context\":\"http://schema.org\",";
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            NullValueHandling = NullValueHandling.Ignore
        };

        //place last
        [DataMember(Name = "itemlist", Order = 9999999)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? ItemList { get; set; }

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

        public Thing()
        {

        }

        public Thing(Uri url)
        {
            Url = url;
        }

        public static implicit operator Thing(Uri url) => new Thing(url);

        public Thing(string name)
        {
            Name = name;
        }

        public static implicit operator Thing(string name) => new Thing(name);
    }
}
