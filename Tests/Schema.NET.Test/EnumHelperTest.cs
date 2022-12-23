namespace Schema.NET.Test;

using Xunit;

public class EnumHelperTest
{
    private enum TestEnum
    {
        DefaultValue,
        RealValue,
    }

    [Theory]
    [InlineData("RealValue")]
    [InlineData("http://schema.org/RealValue")]
    [InlineData("https://schema.org/RealValue")]
    [InlineData("HTTPS://SCHEMA.ORG/RealValue")]
    public void TryParseEnumFromSchemaUri_AllowedValues(string inputValue)
    {
        var result = EnumHelper.TryParseEnumFromSchemaUri(
            typeof(TestEnum),
            inputValue,
            out var parsedValue);

        Assert.True(result);
        Assert.Equal(TestEnum.RealValue, parsedValue);
    }

    [Theory]
    [InlineData("REALVALUE")]
    [InlineData("http://schema.org/REALVALUE")]
    [InlineData("http://schema.org")]
    [InlineData("https://schema.org")]
    [InlineData("http://schema.org/")]
    [InlineData("https://schema.org/")]
    [InlineData("NonValue")]
    [InlineData("http://example.org/RealValue")]
    public void TryParseEnumFromSchemaUri_InvalidValues(string inputValue)
    {
        var result = EnumHelper.TryParseEnumFromSchemaUri(
            typeof(TestEnum),
            inputValue,
            out _);

        Assert.False(result);
    }
}
