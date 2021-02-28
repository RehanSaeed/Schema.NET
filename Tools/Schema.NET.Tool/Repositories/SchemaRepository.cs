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

    public class SchemaRepository : Disposable, ISchemaRepository
    {
#pragma warning disable CA2213 // Members should be disposed
        private readonly HttpClient httpClient;
#pragma warning restore CA2213 // Members should be disposed

        public SchemaRepository() =>
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://schema.org"),
            };

        public async Task<(IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties, IEnumerable<SchemaEnumerationValue> EnumerationValues)> GetObjectsAsync()
        {
            var schemaObjects = await this.GetSchemaObjectsAsync().ConfigureAwait(false);
            var schemaTreeClasses = await this.GetSchemaTreeClassesAsync().ConfigureAwait(false);
            var schemaClasses = schemaObjects.OfType<SchemaClass>().ToArray();

            foreach (var schemaClass in schemaClasses)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => new Uri("schema:" + x.Name) == schemaClass.Id);
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
                return Deserialize<IEnumerable<SchemaObject>>(json, new SchemaPropertyJsonConverter());
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

        protected override void DisposeManaged() => this.httpClient.Dispose();

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
