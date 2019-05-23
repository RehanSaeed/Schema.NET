namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/books
    public class SerializationTest
    {
        private const string Json =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"Book\"," +
                "\"@id\":\"http://example.com/book/1\"," +
                "\"name\":\"The Catcher in the Rye</script><script>alert('gotcha');</script>\"," +
                "\"author\":{" +
                    "\"@type\":\"Person\"," +
                    "\"name\":\"J.D. Salinger</script><script>alert('gotcha');</script>\"" +
                "}" +
            "}";

        private const string JsonHtmlEscaped =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"Book\"," +
                "\"@id\":\"http://example.com/book/1\"," +
                "\"name\":\"The Catcher in the Rye\\u003c/script\\u003e\\u003cscript\\u003ealert(\\u0027gotcha\\u0027);\\u003c/script\\u003e\"," +
                "\"author\":{" +
                    "\"@type\":\"Person\"," +
                    "\"name\":\"J.D. Salinger\\u003c/script\\u003e\\u003cscript\\u003ealert(\\u0027gotcha\\u0027);\\u003c/script\\u003e\"" +
                "}" +
            "}";

        private const string JsonCustom =
            "{\r\n" +
                "  \"@context\": \"http://schema.org\",\r\n" +
                "  \"@type\": \"Person\",\r\n" +
                "  \"name\": \"J.D. Salinger\\u003c/script\\u003e\\u003cscript\\u003ealert(\\u0027gotcha\\u0027);\\u003c/script\\u003e\"\r\n" +
            "}";

        private static readonly Person Person = new Person()
        {
            Name = "J.D. Salinger</script><script>alert('gotcha');</script>",
            Description = (string)null
        };

        private readonly Book book = new Book()
        {
            Id = new Uri("http://example.com/book/1"),
            Name = "The Catcher in the Rye</script><script>alert('gotcha');</script>",
            Author = Person
        };

        private readonly JsonSerializerSettings customSerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
            Formatting = Formatting.Indented
        };

        [Fact]
        public void ToString_UnsafeBookData_ReturnsExpectedJsonLd() =>
            Assert.Equal(Json, this.book.ToString());

        [Fact]
        public void ToHtmlEscapedString_UnsafeBookData_ReturnsExpectedJsonLd() =>
            Assert.Equal(JsonHtmlEscaped, this.book.ToHtmlEscapedString());

        [Fact]
        public void ToStringWithCustomSerializerSettings_UnsafeAuthorData_ReturnsExpectedJsonLd() =>
            Assert.Equal(
                JsonCustom.Replace("\r\n", Environment.NewLine),
                Person.ToString(this.customSerializerSettings));

        [Fact]
        public void ToStringWithNullAssignedProperty_ReturnsExpectedJsonLd()
        {
            var localBusiness = new LocalBusiness()
            {
                PriceRange = "$$$",
                Address = null
            };
            var actual = localBusiness.ToString();
            var expected =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"LocalBusiness\"," +
                "\"priceRange\":\"$$$\"" +
            "}";
            Assert.Equal(expected, actual);
        }
    }
}
