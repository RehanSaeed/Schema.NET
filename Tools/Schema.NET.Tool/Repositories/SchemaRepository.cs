namespace Schema.NET.Tool.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
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

        public async Task<(List<SchemaClass> classes, List<SchemaProperty> properties, List<SchemaEnumerationValue> enumerationValues)> GetObjectsAsync()
        {
            var schemaObjects = await this.GetSchemaObjectsAsync().ConfigureAwait(false);
            var schemaTreeClasses = await this.GetSchemaTreeClassesAsync().ConfigureAwait(false);
            var enumerations = schemaObjects.OfType<SchemaClass>().ToList();
            var classes = schemaObjects.OfType<SchemaClass>().ToList();

            foreach (var enumeration in enumerations)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => new Uri("https://schema.org/" + x.Name) == enumeration.Id);
                if (schemaTreeClass is object)
                {
                    enumeration.Layer = schemaTreeClass.Layer;
                }
            }

            foreach (var c in classes)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => new Uri("https://schema.org/" + x.Name) == c.Id);
                if (schemaTreeClass is object)
                {
                    c.Layer = schemaTreeClass.Layer;
                }

                c.SubClassOf.AddRange(classes.Where(x => c.SubClassOfIds.Contains(x.Id)));
            }

            return (classes,
                schemaObjects.OfType<SchemaProperty>().ToList(),
                schemaObjects.OfType<SchemaEnumerationValue>().ToList());
        }

        public async Task<List<SchemaObject>> GetSchemaObjectsAsync()
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

        public async Task<List<SchemaTreeClass>> GetSchemaTreeClassesAsync()
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
                    .ToList();
            }
        }

        protected override void DisposeManaged() => this.httpClient.Dispose();

        private static T Deserialize<T>(string json, JsonConverter converter) =>
            JsonConvert.DeserializeObject<T>(
                json,
                converter);

        private static T Deserialize<T>(string json) =>
            JsonConvert.DeserializeObject<T>(
                json,
                new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                });
    }
}
