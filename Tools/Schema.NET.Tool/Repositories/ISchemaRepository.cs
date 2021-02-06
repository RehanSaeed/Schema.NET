namespace Schema.NET.Tool.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public interface ISchemaRepository
    {
        Task<(List<SchemaClass> Classes, List<SchemaProperty> Properties, List<SchemaEnumerationValue> EnumerationValues)> GetObjectsAsync();
    }
}
