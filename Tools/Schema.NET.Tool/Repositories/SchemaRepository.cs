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
        public static readonly Func<SchemaObject, bool> DefaultFilter = (SchemaObject x) => !x.IsArchived && !x.IsMeta && !x.IsPending;

        private readonly HttpClient httpClient;

        public SchemaRepository(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<(IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties, IEnumerable<SchemaEnumerationValue> EnumerationValues)> GetObjectsAsync(Func<SchemaObject, bool> filter)
        {
            if (filter == null)
            {
                filter = DefaultFilter;
            }

            var schemaObjects = await this.GetSchemaObjectsAsync().ConfigureAwait(false);
            schemaObjects = schemaObjects.Where(filter).ToArray();

            var schemaTreeClasses = await this.GetSchemaTreeClassesAsync().ConfigureAwait(false);
            var schemaClasses = schemaObjects.OfType<SchemaClass>().ToArray();

            foreach (var schemaClass in schemaClasses)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => x.Name.Equals(schemaClass.Label, StringComparison.OrdinalIgnoreCase));
                if (schemaTreeClass is not null)
                {
                    schemaClass.Layer = schemaTreeClass.Layer;
                }

                schemaClass.SubClassOf.AddRange(schemaClasses.Where(x => schemaClass.SubClassOfIds.Contains(x.Id)));
            }

            return (schemaClasses,
                schemaObjects.OfType<SchemaProperty>().ToArray(),
                schemaObjects.OfType<SchemaEnumerationValue>().ToArray());
        }

        public async Task<IEnumerable<SchemaObject>> GetSchemaObjectsAsync()
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

        public async Task<IEnumerable<SchemaTreeClass>> GetSchemaTreeClassesAsync()
        {
            using (var response = await this.httpClient
                .GetAsync(new Uri("/docs/tree.jsonld", UriKind.Relative))
                .ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var schemaClass = Deserialize<SchemaTreeClass>(json);
                return EnumerableExtensions
                    .Traverse(schemaClass, x => x.Children)
                    .ToArray();
            }
        }

        private static T Deserialize<T>(string json, JsonConverter converter)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            options.Converters.Add(converter);
            return JsonSerializer.Deserialize<T>(json, options);
        }

        private static T Deserialize<T>(string json) =>
            JsonSerializer.Deserialize<T>(
                json,
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                });
    }
}
