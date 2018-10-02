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
        private static readonly Person Person = new Person()
        {
            Name = "J.D. Salinger</script><script>alert('gotcha');</script>",
            Description = null
        };

        private readonly Book book = new Book()
        {
            Id = new Uri("http://example.com/book/1"),
            Name = "The Catcher in the Rye</script><script>alert('gotcha');</script>",
            Author = Person
        };

        private readonly string json =
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

        private readonly string jsonHtmlEscaped =
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

        private readonly JsonSerializerSettings customSerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            },
            NullValueHandling = NullValueHandling.Include, // changed
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
        };

        private readonly string jsonCustom =
        "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"Person\"," +
            "\"@id\":null," +
            "\"name\":\"J.D. Salinger\\u003c/script\\u003e\\u003cscript\\u003ealert(\\u0027gotcha\\u0027);\\u003c/script\\u003e\"," +
            "\"description\":null,\"additionalType\":null,\"alternateName\":null,\"disambiguatingDescription\":null,\"identifier\":null," +
            "\"image\":null,\"mainEntityOfPage\":null,\"potentialAction\":null,\"sameAs\":null,\"url\":null,\"additionalName\":null," +
            "\"address\":null,\"affiliation\":null,\"alumniOf\":null,\"award\":null,\"birthDate\":null,\"birthPlace\":null,\"brand\":null," +
            "\"children\":null,\"colleague\":null,\"contactPoint\":null,\"deathDate\":null,\"deathPlace\":null,\"duns\":null,\"email\":null," +
            "\"familyName\":null,\"faxNumber\":null,\"follows\":null,\"funder\":null,\"gender\":null,\"givenName\":null," +
            "\"globalLocationNumber\":null,\"hasOfferCatalog\":null,\"hasPOS\":null,\"height\":null,\"homeLocation\":null," +
            "\"honorificPrefix\":null,\"honorificSuffix\":null,\"isicV4\":null,\"jobTitle\":null,\"knows\":null,\"makesOffer\":null," +
            "\"memberOf\":null,\"naics\":null,\"nationality\":null,\"netWorth\":null,\"owns\":null,\"parent\":null,\"performerIn\":null," +
            "\"publishingPrinciples\":null,\"relatedTo\":null,\"seeks\":null,\"sibling\":null,\"sponsor\":null,\"spouse\":null,\"taxID\":null," +
            "\"telephone\":null,\"vatID\":null,\"weight\":null,\"workLocation\":null,\"worksFor\":null}";

        [Fact]
        public void ToString_UnsafeBookData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.book.ToString());

        [Fact]
        public void ToHtmlEscapedString_UnsafeBookData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.jsonHtmlEscaped, this.book.ToHtmlEscapedString());

        [Fact]
        public void ToStringWithCustomSerializerSettings_UnsafeAuthorData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.jsonCustom, Person.ToString(this.customSerializerSettings));
    }
}
