namespace Schema.NET.Tool.Repositories;

using System.Collections.Generic;
using Schema.NET.Tool.Models;

public interface ISchemaRepository
{
    (IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties, IEnumerable<SchemaEnumerationValue> EnumerationValues) GetObjects();
}
