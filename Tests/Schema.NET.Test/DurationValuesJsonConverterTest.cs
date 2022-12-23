namespace Schema.NET.Test;

using System;
using System.Text.Json.Serialization;
using Xunit;

public class DurationValuesJsonConverterTest
{
    [Fact]
    public void WriteJson_TimeSpan_ISO8601_Duration()
    {
        var value = new OneOrMany<TimeSpan>(new TimeSpan(12, 34, 56));
        var json = SerializeObject(value);

        const string expected = /*lang=json,strict*/
            """
            {"Property":"PT12H34M56S"}
            """;
        Assert.Equal(expected, json);
    }

    private static string SerializeObject<T>(T value)
        where T : struct, IValues =>
        SchemaSerializer.SerializeObject(new TestModel<T> { Property = value });

    private sealed class TestModel<T>
        where T : struct, IValues
    {
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public T Property { get; set; }
    }
}
