using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Schema.NET
{

    public class ThingConverter : JsonConverter
    {
        private const string NamespacePrefix = "Schema.NET.";

        public override bool CanConvert(Type objectType) => typeof(Thing).IsAssignableFrom(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JContainer lJContainer = default(JContainer);
            
            if (reader.TokenType == JsonToken.StartObject)
            {
                lJContainer = JObject.Load(reader);
                var typeName = GetTypeNameFromToken(lJContainer);
                var builtType = Type.GetType($"{NamespacePrefix}{typeName}");

                if (builtType == null)
                {
                    //try and find using reflection
                    builtType = typeof(Thing).Assembly.GetTypes().FirstOrDefault(p => p.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase));
                }

                if (builtType == null)
                {
                    builtType = typeof(Thing);
                }

                existingValue = Convert.ChangeType(existingValue, builtType);
                existingValue = Activator.CreateInstance(builtType);

                serializer.Populate(lJContainer.CreateReader(), existingValue);
            }

            return existingValue;
        }

        private static object SanitizeReaderValue(JsonReader reader, JsonToken tokenType) =>
            tokenType == JsonToken.Integer ? Convert.ToInt32(reader.Value) : reader.Value;

        private static string GetTypeNameFromToken(JToken token)
        {
            var typeNameToken = token.Values().FirstOrDefault(t => t.Path.EndsWith("@type"));
            return typeNameToken?.Value<string>();
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
