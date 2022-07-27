namespace Schema.NET.Test;

using System;
using System.Text.Json.Serialization;
using Xunit;

public class DateValuesJsonConverterTest
{
    [Fact]
    public void WriteJson_DateTime_ISO8601_Date()
    {
        var value = new OneOrMany<DateTime>(new DateTime(2000, 1, 1, 12, 34, 56));
        var json = SerializeObject(value);

        var expectedJson = /*lang=json,strict*/
            """
            {"Property":"2000-01-01"}
            """;
        Assert.Equal(expectedJson, json);
    }

    private static string SerializeObject<T>(T value)
        where T : struct, IValues =>
        SchemaSerializer.SerializeObject(new TestModel<T> { Property = value });

    private sealed class TestModel<T>
        where T : struct, IValues
    {
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public T Property { get; set; }
    }
}
