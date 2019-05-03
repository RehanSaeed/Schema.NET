namespace Schema.NET.Tool.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Schema.NET.Tool.Constants;
    using Schema.NET.Tool.Models;

    public class SchemaPropertyJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(List<SchemaObject>);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var token = JToken.Load(reader);
                var graphArray = ((JArray)token["@graph"]).ToList();
                return graphArray.Select(Read).Where(x => x != null).ToList();
            }

            return Enumerable.Empty<SchemaObject>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        private static SchemaObject Read(JToken token)
        {
            var commentToken = token["rdfs:comment"];
            if (commentToken == null)
            {
                return null;
            }

            var supercededByToken = token["http://schema.org/supersededBy"];
            if (supercededByToken != null)
            {
                // Ignore deprecated properties.
                return null;
            }

            var id = new Uri(token["@id"].Value<string>());
            var types = GetTokenValues(token["@type"]).ToList();
            var comment = token["rdfs:comment"].Value<string>();
            var label = GetLabel(token);
            var domainIncludes = GetTokenValues(token["http://schema.org/domainIncludes"], "@id").ToList();
            var rangeIncludes = GetTokenValues(token["http://schema.org/rangeIncludes"], "@id").ToList();
            var subClassOf = GetTokenValues(token["rdfs:subClassOf"], "@id").ToList();
            var isPartOf = GetTokenValues(token["http://schema.org/isPartOf"]).FirstOrDefault();
            var layer = isPartOf == null ?
                LayerName.Core :
                isPartOf.Replace("http://", string.Empty, StringComparison.Ordinal).Replace(".schema.org", string.Empty, StringComparison.Ordinal);

            if (types.Any(type => string.Equals(type, "rdfs:Class", StringComparison.OrdinalIgnoreCase)))
            {
                var schemaClass = new SchemaClass()
                {
                    Comment = comment,
                    Id = id,
                    Label = label,
                    Layer = layer,
                };
                schemaClass.SubClassOfIds.AddRange(subClassOf);
                schemaClass.Types.AddRange(types);
                return schemaClass;
            }
            else if (types.Any(type => string.Equals(type, "rdf:Property", StringComparison.OrdinalIgnoreCase)))
            {
                var schemaProperty = new SchemaProperty()
                {
                    Comment = comment,
                    Id = id,
                    Label = label,
                    Layer = layer,
                };
                schemaProperty.DomainIncludes.AddRange(domainIncludes);
                schemaProperty.RangeIncludes.AddRange(rangeIncludes);
                schemaProperty.Types.AddRange(types);
                return schemaProperty;
            }
            else
            {
                var schemaEnumerationValue = new SchemaEnumerationValue()
                {
                    Comment = comment,
                    Id = id,
                    Label = label,
                    Layer = layer,
                };
                schemaEnumerationValue.Types.AddRange(types);
                return schemaEnumerationValue;
            }
        }

        private static string GetLabel(JToken token)
        {
            var labelToken = token["rdfs:label"];

            if (labelToken.Type == JTokenType.String)
            {
                return labelToken.Value<string>();
            }

            return labelToken["@value"].Value<string>();
        }

        private static IEnumerable<string> GetTokenValues(JToken token)
        {
            if (token != null)
            {
                if (token.Type == JTokenType.String)
                {
                    yield return token.Value<string>();
                }
                else if (token.Type == JTokenType.Array)
                {
                    foreach (var subToken in (JArray)token)
                    {
                        yield return subToken.Value<string>();
                    }
                }
            }
        }

        private static IEnumerable<Uri> GetTokenValues(JToken token, string name)
        {
            if (token != null)
            {
                if (token.Type == JTokenType.Object)
                {
                    yield return new Uri(token[name].Value<string>());
                }
                else if (token.Type == JTokenType.Array)
                {
                    foreach (var subToken in (JArray)token)
                    {
                        yield return new Uri(subToken[name].Value<string>());
                    }
                }
            }
        }
    }
}
