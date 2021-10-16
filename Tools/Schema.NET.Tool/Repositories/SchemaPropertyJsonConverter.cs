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
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(typeToConvert);
#else
            if (typeToConvert is null)
            {
                throw new ArgumentNullException(nameof(typeToConvert));
            }
#endif

            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var token = JsonDocument.ParseValue(ref reader);
                var graphArray = token.RootElement.GetProperty("@graph").EnumerateArray();
                return graphArray.Select(Read).Where(x => x is not null).ToList()!;
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

            if (!token.TryGetProperty("@id", out var idToken) || idToken.ValueKind != JsonValueKind.String)
            {
                return null;
            }

            var id = SchemaOrgUrl(idToken.GetString()!);
            var types = GetTokenValues(token, "@type").ToArray();

            string comment;
            if (commentToken.ValueKind == JsonValueKind.Object && commentToken.TryGetProperty("@value", out var commentValueToken))
            {
                comment = commentValueToken.GetString()!;
            }
            else
            {
                comment = commentToken.GetString()!;
            }

            var label = GetLabel(token);
            var isPartOf = GetTokenValues(token, "schema:isPartOf", "@id").Select(s => new Uri(s)).FirstOrDefault();

            var layer = LayerName.Core;
            if (isPartOf is not null && isPartOf.Host != "schema.org")
            {
#if NETSTANDARD2_0
                layer = isPartOf.Host.Replace(".schema.org", string.Empty);
#else
                layer = isPartOf.Host.Replace(".schema.org", string.Empty, StringComparison.Ordinal);
#endif
            }

            if (types.Any(type => string.Equals(type, "rdfs:Class", StringComparison.Ordinal)))
            {
                var schemaClass = new SchemaClass(layer, id, label, comment);

                var subClassOf = GetTokenValues(token, "rdfs:subClassOf", "@id").Select(SchemaOrgUrl);
                schemaClass.SubClassOfIds.AddRange(subClassOf);

                schemaClass.Types.AddRange(types);
                return schemaClass;
            }
            else if (types.Any(type => string.Equals(type, "rdf:Property", StringComparison.Ordinal)))
            {
                var schemaProperty = new SchemaProperty(layer, id, label, comment);

                var domainIncludes = GetTokenValues(token, "schema:domainIncludes", "@id").Select(SchemaOrgUrl);
                schemaProperty.DomainIncludes.AddRange(domainIncludes);

                var rangeIncludes = GetTokenValues(token, "schema:rangeIncludes", "@id").Select(SchemaOrgUrl);
                schemaProperty.RangeIncludes.AddRange(rangeIncludes);

                schemaProperty.Types.AddRange(types);
                return schemaProperty;
            }
            else
            {
                var schemaEnumerationValue = new SchemaEnumerationValue(layer, id, label, comment);
                schemaEnumerationValue.Types.AddRange(types.Select(SchemaOrgUrl).Select(u => u.ToString()));
                return schemaEnumerationValue;
            }
        }

        private static string GetLabel(JsonElement token)
        {
            if (token.TryGetProperty("rdfs:label", out var labelToken))
            {
                if (labelToken.ValueKind == JsonValueKind.String)
                {
                    return labelToken.GetString()!;
                }
                else if (labelToken.TryGetProperty("@value", out var labelValueToken) && labelValueToken.ValueKind == JsonValueKind.String)
                {
                    return labelValueToken.GetString()!;
                }
            }

            throw new ArgumentException($"Unable to determine label for token {token}.");
        }

        private static IEnumerable<string> GetTokenValues(JsonElement source, string property)
        {
            if (source.TryGetProperty(property, out var token))
            {
                if (token.ValueKind == JsonValueKind.String)
                {
                    yield return token.GetString()!;
                }
                else if (token.ValueKind == JsonValueKind.Array)
                {
                    foreach (var subToken in token.EnumerateArray())
                    {
                        if (subToken.ValueKind == JsonValueKind.String)
                        {
                            yield return subToken.GetString()!;
                        }
                    }
                }
            }
        }

        private static IEnumerable<string> GetTokenValues(JsonElement source, string property, string name)
        {
            if (source.TryGetProperty(property, out var token))
            {
                if (token.ValueKind == JsonValueKind.Object)
                {
                    if (token.TryGetProperty(name, out var innerToken) && innerToken.ValueKind == JsonValueKind.String)
                    {
                        yield return innerToken.GetString()!;
                    }
                }
                else if (token.ValueKind == JsonValueKind.Array)
                {
                    foreach (var subToken in token.EnumerateArray())
                    {
                        if (subToken.TryGetProperty(name, out var innerToken) && innerToken.ValueKind == JsonValueKind.String)
                        {
                            yield return innerToken.GetString()!;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Converts "schema:" URLs to "https://schema.org/" URLs.
        /// </summary>
        /// <param name="url">The URL to convert.</param>
        /// <returns>The updated URL with the new scheme and host.</returns>
        private static Uri SchemaOrgUrl(string url) => new UriBuilder(url)
        {
            Scheme = "https",
            Host = "schema.org",
        }.Uri;
    }
}
