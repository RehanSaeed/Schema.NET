namespace Schema.NET.Tool.Repositories
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public class SchemaRepository : ISchemaRepository
    {
        private readonly Stream fileStream;

        public SchemaRepository(Stream fileStream) => this.fileStream = fileStream;

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

        public async Task<IEnumerable<SchemaObject>?> GetSchemaObjectsAsync() => await DeserializeAsync<List<SchemaObject>>(this.fileStream, new SchemaPropertyJsonConverter()).ConfigureAwait(false);

        private static async Task<T?> DeserializeAsync<T>(Stream jsonStream, JsonConverter converter)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            options.Converters.Add(converter);
            return await JsonSerializer.DeserializeAsync<T>(jsonStream, options).ConfigureAwait(false);
        }
    }
}
