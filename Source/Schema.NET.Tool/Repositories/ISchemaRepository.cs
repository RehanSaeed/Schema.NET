namespace Schema.NET.Tool.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public interface ISchemaRepository
    {
        Task<(List<SchemaClass> classes, List<SchemaProperty> properties, List<SchemaEnumerationValue> enumerationValues)> GetObjects();
    }
}
