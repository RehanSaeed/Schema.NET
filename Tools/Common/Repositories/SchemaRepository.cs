namespace Schema.NET.Tool.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.CodeAnalysis.Text;
using Models;

public class SchemaRepository : ISchemaRepository
{
    private readonly SourceText jsonLd;

    public SchemaRepository(SourceText jsonLd) => this.jsonLd = jsonLd;

    public static readonly JsonSerializerOptions DefaultOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new SchemaPropertyJsonConverter() }
    };

    public (IEnumerable<SchemaClass> Classes, IEnumerable<SchemaProperty> Properties,
        IEnumerable<SchemaEnumerationValue> EnumerationValues) GetObjects()
    {
        var schemaObjects = Deserialize<List<SchemaObject>>(this.jsonLd.ToString()) ??
                            throw new InvalidOperationException("No schema objects found.");

        var schemaClasses = schemaObjects.OfType<SchemaClass>().ToArray();

        foreach (var schemaClass in schemaClasses)
        {
            schemaClass.SubClassOf.AddRange(schemaClasses.Where(x =>
                x.Id is not null && schemaClass.SubClassOfIds.Contains(x.Id)));
        }

        return (schemaClasses,
            schemaObjects.OfType<SchemaProperty>().ToArray(),
            schemaObjects.OfType<SchemaEnumerationValue>().ToArray());
    }

    private static T? Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, DefaultOptions);
}
