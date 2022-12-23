namespace Schema.NET.Test;

using Xunit;

public class ContextJsonConverterTest
{
    [Fact]
    public void ReadJson_StringContext_ContextHasName()
    {
        var json = /*lang=json,strict*/
            """
            {"@context":"foo","@type":"Thing"}
            """;

        var thing = SchemaSerializer.DeserializeObject<Thing>(json);

        Assert.NotNull(thing?.Context);
        Assert.Equal("foo", thing?.Context.Name);
        Assert.Null(thing?.Context.Language);
    }

    [Fact]
    public void ReadJson_ObjectContextWithName_ContextHasName()
    {
        var json = /*lang=json,strict*/
            """
            {"@context":{"name":"foo"},"@type":"Thing"}
            """;

        var thing = SchemaSerializer.DeserializeObject<Thing>(json);

        Assert.NotNull(thing?.Context);
        Assert.Equal("foo", thing?.Context.Name);
        Assert.Null(thing?.Context.Language);
    }

    [Fact]
    public void ReadJson_ObjectContextWithNameAndLanguage_ContextHasNameAndLanguage()
    {
        var json = /*lang=json,strict*/
            """
            {"@context":{"name":"foo","@language":"en"},"@type":"Thing"}
            """;

        var thing = SchemaSerializer.DeserializeObject<Thing>(json);

        Assert.NotNull(thing?.Context);
        Assert.Equal("foo", thing?.Context.Name);
        Assert.Equal("en", thing?.Context.Language);
    }

    [Fact]
    public void ReadJson_ArrayContextWithNameAndLanguage_ContextHasNameAndLanguage()
    {
        var json = /*lang=json,strict*/
            """
            {"@context":["foo",{"@language":"en"}],"@type":"Thing"}
            """;

        var thing = SchemaSerializer.DeserializeObject<Thing>(json);

        Assert.NotNull(thing?.Context);
        Assert.Equal("foo", thing?.Context.Name);
        Assert.Equal("en", thing?.Context.Language);
    }

    [Fact]
    public void WriteJson_StringContext_ContextHasName()
    {
        var json = new Thing().ToString();

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":"https://schema.org","@type":"Thing"}
            """;
        Assert.Equal(expectedJson, json);
    }

    [Fact]
    public void WriteJson_ObjectContextWithLanguage_ContextHasName()
    {
        var thing = new Thing();
        thing.Context.Language = "en";

        var json = thing.ToString();

        var expectedJson = /*lang=json,strict*/
            """
            {"@context":{"name":"https://schema.org","@language":"en"},"@type":"Thing"}
            """;
        Assert.Equal(expectedJson, json);
    }
}
