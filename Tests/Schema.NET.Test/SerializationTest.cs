namespace Schema.NET.Test
{
    using System;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/books
    public class SerializationTest
    {
        private readonly Book book = new Book()
        {
            Id = new Uri("http://example.com/book/1"),
            Name = "The Catcher in the Rye</script><script>alert('gotcha');</script>",
            Author = new Person()
            {
                Name = "J.D. Salinger</script><script>alert('gotcha');</script>"
            }
        };

        private readonly string json =
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

        [Fact]
        public void ToString_UnsafeBookData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.book.ToString());
    }
}
