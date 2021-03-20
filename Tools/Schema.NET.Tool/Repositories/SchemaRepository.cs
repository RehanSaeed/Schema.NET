namespace Schema.NET.Tool.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public class SchemaRepository : ISchemaRepository
    {
        private readonly HttpClient httpClient;

        public SchemaRepository(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<(IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties, IEnumerable<SchemaEnumerationValue> EnumerationValues)> GetObjectsAsync()
        {
            var schemaObjects = await this.GetSchemaObjectsAsync().ConfigureAwait(false);
            schemaObjects = schemaObjects.ToArray();

            var schemaClasses = schemaObjects.OfType<SchemaClass>().ToArray();

            foreach (var schemaClass in schemaClasses)
            {
                schemaClass.SubClassOf.AddRange(schemaClasses.Where(x => x.Id is not null && schemaClass.SubClassOfIds.Contains(x.Id)));
            }

            return (schemaClasses,
                schemaObjects.OfType<SchemaProperty>().ToArray(),
                schemaObjects.OfType<SchemaEnumerationValue>().ToArray());
        }

        public async Task<IEnumerable<SchemaObject>?> GetSchemaObjectsAsync()
        {
            using (var response = await this.httpClient
                .GetAsync(new Uri("/version/latest/schemaorg-all-https.jsonld", UriKind.Relative))
                .ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return Deserialize<List<SchemaObject>>(json, new SchemaPropertyJsonConverter());
            }
        }

        private static T? Deserialize<T>(string json, JsonConverter converter)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            options.Converters.Add(converter);
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
