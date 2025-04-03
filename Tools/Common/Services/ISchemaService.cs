namespace Schema.NET.Tool.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using Schema.NET.Tool.Models;

public interface ISchemaService
{
    Task<List<SchemaClass>> GetSchemaClassesAsync();

    Task<List<SchemaClass>> GetSchemaClassesWithPropertiesAsync();

    Task<List<SchemaProperty>> GetSchemaPropertiesAsync();
}
