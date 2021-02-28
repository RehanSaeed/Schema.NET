namespace Schema.NET.Tool.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Models;

    public interface ISchemaRepository
    {
        Task<(IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties, IEnumerable<SchemaEnumerationValue> EnumerationValues)> GetObjectsAsync(Func<SchemaObject, bool> filter = null);
    }
}
