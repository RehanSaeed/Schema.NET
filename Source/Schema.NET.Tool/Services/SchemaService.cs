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

        public async Task<List<SchemaClass>> GetSchemaClasses()
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

        public async Task<List<SchemaClass>> GetSchemaClassesWithProperties()
        {
            var schemaClasses = await this.GetSchemaClasses();
            var schemaProperties = await this.GetSchemaProperties();
            foreach (var schemaProperty in schemaProperties)
            {
                if (schemaProperty.IsClass)
                {
                    // {
                    //   "@id": "http://schema.org/CafeOrCoffeeShop",
                    //   "@type": "rdfs:Class",
                    //   "rdfs:comment": "A cafe or coffee shop.",
                    //   "rdfs:label": "CafeOrCoffeeShop",
                    //   "rdfs:subClassOf": {
                    //     "@id": "http://schema.org/FoodEstablishment"
                    //   }
                    // }
                }
                else
                {
                    if (schemaProperty.Url.StartsWith("http://schema.org"))
                    {

                    }
                    else
                    {
                        // {
                        //   "@id": "https://www.w3.org/wiki/WebSchemas/SchemaDotOrgSources#STI_Accommodation_Ontology",
                        //   "@type": "http://schema.org/Organization",
                        //   "rdfs:comment": "This element is based on the STI Accommodation Ontology, see <a href=\"http://ontologies.sti-innsbruck.at/acco/ns.html\">http://ontologies.sti-innsbruck.at/acco/ns.html</a> for details.\n    Many class and property definitions are inspired by or based on abstracts from Wikipedia, the free encyclopedia.",
                        //   "rdfs:label": "STI Accommodation Ontology"
                        // }
                    }
                }
            }

            foreach (var schemaClass in schemaClasses)
            {
                if (schemaClass.IsPrimitive || schemaClass.IsMeta || schemaClass.IsPending || schemaClass.IsArchived)
                {
                    // Ignore
                }
                else if (schemaClass.IsEnum)
                {
                    foreach (var schemaProperty in schemaProperties
                        .Where(x => x.IsEnumValue && string.Equals(x.PropertyType, schemaClass.Url, StringComparison.Ordinal)))
                    {
                        schemaProperty.Classes.Add(schemaClass);
                        schemaClass.Properties.Add(schemaProperty);
                    }
                }
                else if (schemaClass.IsClass)
                {
                    foreach (var schemaProperty in schemaProperties
                        .Where(x => x.IsProperty && x.ClassUrls.Contains(schemaClass.Url)))
                    {
                        schemaProperty.Classes.Add(schemaClass);
                        schemaClass.Properties.Add(schemaProperty);
                    }
                }
            }

            return schemaClasses.Where(x => !x.IsPrimitive && !x.IsPending && !x.IsMeta&& !x.IsArchived).ToList();
        }

        public async Task<List<SchemaProperty>> GetSchemaProperties()
        {
            var response = await this.httpClient.GetAsync("/version/latest/schema.jsonld");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return Deserialize<List<SchemaProperty>>(json, new SchemaPropertyJsonConverter());
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
