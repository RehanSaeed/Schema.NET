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

    public class SchemaRepository : ISchemaRepository
    {
        private readonly HttpClient httpClient;

        public SchemaRepository() =>
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://schema.org")
            };

        public async Task<(List<SchemaClass> classes, List<SchemaProperty> properties, List<SchemaEnumerationValue> enumerationValues)> GetObjects()
        {
            var schemaObjects = await this.GetSchemaObjects();
            var schemaTreeClasses = await this.GetSchemaTreeClasses();
            var enumerations = schemaObjects.OfType<SchemaClass>().ToList();
            var classes = schemaObjects.OfType<SchemaClass>().ToList();

            foreach (var enumeration in enumerations)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => new Uri("http://schema.org/" + x.Name) == enumeration.Id);
                if (schemaTreeClass != null)
                {
                    enumeration.Layer = schemaTreeClass.Layer;
                }
            }

            foreach (var @class in classes)
            {
                var schemaTreeClass = schemaTreeClasses.FirstOrDefault(x => new Uri("http://schema.org/" + x.Name) == @class.Id);
                if (schemaTreeClass != null)
                {
                    @class.Layer = schemaTreeClass.Layer;
                }

                @class.SubClassOf = classes.Where(x => @class.SubClassOfIds.Contains(x.Id)).ToList();
            }

            return (classes,
                schemaObjects.OfType<SchemaProperty>().ToList(),
                schemaObjects.OfType<SchemaEnumerationValue>().ToList());
        }

        public async Task<List<SchemaObject>> GetSchemaObjects()
        {
            var response = await this.httpClient.GetAsync("/version/latest/all-layers.jsonld");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return Deserialize<List<SchemaObject>>(json, new SchemaPropertyJsonConverter());
        }

        public async Task<List<SchemaTreeClass>> GetSchemaTreeClasses()
        {
            var response = await this.httpClient.GetAsync("/docs/tree.jsonld");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var schemaClass = Deserialize<SchemaTreeClass>(json);
            return EnumerableExtensions
                .Traverse(schemaClass, x => x.Children)
                .ToList();
        }

        private static T Deserialize<T>(string json, JsonConverter converter) =>
            JsonConvert.DeserializeObject<T>(
                json,
                converter);

        private static T Deserialize<T>(string json) =>
            JsonConvert.DeserializeObject<T>(
                json,
                new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
    }
}
