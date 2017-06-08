namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Schema.NET.Tool.Models;

    public class SchemaPropertyJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(IEnumerable<SchemaProperty>);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var token = JToken.Load(reader);
                var graphArray = (JArray)token["@graph"];
                return graphArray
                    .Select(
                        x =>
                        {
                            var commentToken = x["rdfs:comment"];
                            if (commentToken == null)
                            {
                                return null;
                            }

                            var supercededByToken = x["http://schema.org/supersededBy"];
                            if (supercededByToken != null)
                            {
                                // Ignore deprecated properties.
                                return null;
                            }

                            var comment = x["rdfs:comment"].Value<string>();
                            var domainIncludes = GetTokenValues(x["http://schema.org/domainIncludes"]).ToList();
                            var id = x["@id"].Value<string>();
                            var label = x["rdfs:label"].Value<string>();
                            var rangeIncludes = GetTokenValues(x["http://schema.org/rangeIncludes"]).ToList();
                            var parents = GetTokenValues(x["rdfs:subClassOf"]).ToList();
                            var typeToken = x["@type"];
                            string type;
                            if (typeToken.Type == JTokenType.Array)
                            {
                                type = label;
                            }
                            else
                            {
                                type = x["@type"].Value<string>();
                            }

                            return new SchemaProperty()
                            {
                                ClassUrls = domainIncludes,
                                Comment = comment,
                                Name = label,
                                Parents = parents,
                                PropertyType = type,
                                Types = rangeIncludes
                                    .Select(y =>
                                        new SchemaType()
                                        {
                                            Name = y.Replace("http://schema.org/", string.Empty),
                                            Url = y
                                        })
                                    .ToList(),
                                Url = id,
                            };
                        })
                    .Where(x => x != null)
                    .ToList();
            }

            return Enumerable.Empty<SchemaProperty>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<string> GetTokenValues(JToken token)
        {
            if (token != null)
            {
                if (token.Type == JTokenType.Object)
                {
                    yield return token["@id"].Value<string>();
                }
                else if (token.Type == JTokenType.Array)
                {
                    foreach (var subToken in ((JArray)token))
                    {
                        yield return subToken["@id"].Value<string>();
                    }
                }
            }
        }
    }
}
