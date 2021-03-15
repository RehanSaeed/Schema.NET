namespace Schema.NET.Tool.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Schema.NET.Tool.Constants;
    using Schema.NET.Tool.Models;

    public class SchemaPropertyJsonConverter : JsonConverter<List<SchemaObject>>
    {
        public override List<SchemaObject> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert is null)
            {
                throw new ArgumentNullException(nameof(typeToConvert));
            }

            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var token = JsonDocument.ParseValue(ref reader);
                var graphArray = token.RootElement.GetProperty("@graph").EnumerateArray();
                return graphArray.Select(Read).Where(x => x is not null).ToList();
            }

            return new List<SchemaObject>();
        }

        public override void Write(Utf8JsonWriter writer, List<SchemaObject> value, JsonSerializerOptions options) =>
            throw new NotImplementedException();

        private static SchemaObject? Read(JsonElement token)
        {
            if (!token.TryGetProperty("rdfs:comment", out var commentToken))
            {
                return null;
            }

            if (token.TryGetProperty("schema:supersededBy", out var supercededByToken))
            {
                // Ignore deprecated properties.
                return null;
            }

            var id = SchemaOrgUrl(token.GetProperty("@id").GetString());
            var types = GetTokenValues(token, "@type").ToArray();

            string? comment;
            if (commentToken.ValueKind == JsonValueKind.Object && commentToken.TryGetProperty("@value", out var commentValueToken))
            {
                comment = commentValueToken.GetString();
            }
            else
            {
                comment = commentToken.GetString();
            }

            var label = GetLabel(token);
            var domainIncludes = GetTokenValues(token, "schema:domainIncludes", "@id").Select(SchemaOrgUrl).ToArray();
            var rangeIncludes = GetTokenValues(token, "schema:rangeIncludes", "@id").Select(SchemaOrgUrl).ToArray();
            var subClassOf = GetTokenValues(token, "rdfs:subClassOf", "@id").Select(SchemaOrgUrl).ToArray();
            var isPartOf = GetTokenValues(token, "schema:isPartOf", "@id").Select(s => new Uri(s)).FirstOrDefault();

            var layer = LayerName.Core;
            if (isPartOf is not null && isPartOf.Host != "schema.org")
            {
                layer = isPartOf.Host.Replace(".schema.org", string.Empty);
            }

            if (types.Any(type => string.Equals(type, "rdfs:Class", StringComparison.Ordinal)))
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
            else if (types.Any(type => string.Equals(type, "rdf:Property", StringComparison.Ordinal)))
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
                schemaEnumerationValue.Types.AddRange(types.Select(SchemaOrgUrl).Select(u => u.ToString()).ToArray());
                return schemaEnumerationValue;
            }
        }

        private static string? GetLabel(JsonElement token)
        {
            var labelToken = token.GetProperty("rdfs:label");

            if (labelToken.ValueKind == JsonValueKind.String)
            {
                return labelToken.GetString();
            }

            return labelToken.GetProperty("@value").GetString();
        }

        private static IEnumerable<string?> GetTokenValues(JsonElement source, string property)
        {
            if (source.TryGetProperty(property, out var token))
            {
                if (token.ValueKind == JsonValueKind.String)
                {
                    yield return token.GetString();
                }
                else if (token.ValueKind == JsonValueKind.Array)
                {
                    foreach (var subToken in token.EnumerateArray())
                    {
                        yield return subToken.GetString();
                    }
                }
            }
        }

        private static IEnumerable<string?> GetTokenValues(JsonElement source, string property, string name)
        {
            if (source.TryGetProperty(property, out var token))
            {
                if (token.ValueKind == JsonValueKind.Object)
                {
                    yield return token.GetProperty(name).GetString();
                }
                else if (token.ValueKind == JsonValueKind.Array)
                {
                    foreach (var subToken in token.EnumerateArray())
                    {
                        yield return subToken.GetProperty(name).GetString();
                    }
                }
            }
        }

        /// <summary>
        /// Converts "schema:" URLs to "https://schema.org/" URLs.
        /// </summary>
        /// <param name="url">The URL to convert.</param>
        /// <returns>The updated URL with the new scheme and host.</returns>
        private static Uri SchemaOrgUrl(string? url) => new UriBuilder(url)
        {
            Scheme = "https",
            Host = "schema.org",
        }.Uri;
    }
}
