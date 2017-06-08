namespace Schema.NET.Tool.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public interface ISchemaService
    {
        Task<IEnumerable<SchemaClass>> GetSchemaClasses();

        Task<IEnumerable<SchemaProperty>> GetSchemaProperties();
    }
}
