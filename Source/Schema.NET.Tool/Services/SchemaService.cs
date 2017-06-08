namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Schema.NET.Tool.Models;

    public class SchemaService : ISchemaService
    {
        private readonly HttpClient httpClient;

        public SchemaService() =>
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://schema.org")
            };

        public async Task<IEnumerable<SchemaClass>> GetSchemaClasses()
        {
            var response = await this.httpClient.GetAsync("/docs/tree.jsonld");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var schemaClass = Deserialize<SchemaClass>(json);
            SetParent(schemaClass);
            return EnumerableExtensions
                .Traverse(schemaClass, x => x.Children)
                .ToList();
        }

        public async Task<IEnumerable<SchemaProperty>> GetSchemaProperties()
        {
            var response = await this.httpClient.GetAsync("/version/latest/schema.jsonld");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return Deserialize<IEnumerable<SchemaProperty>>(json, new SchemaPropertyJsonConverter());
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

        private static void SetParent(SchemaClass schemaClass)
        {
            if (schemaClass.Children != null)
            {
                foreach (var child in schemaClass.Children)
                {
                    child.Parent = schemaClass;
                    SetParent(child);
                }
            }
        }
    }
}
