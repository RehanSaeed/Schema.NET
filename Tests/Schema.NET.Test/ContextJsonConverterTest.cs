namespace Schema.NET.Test
{
    using Newtonsoft.Json;
    using Xunit;

    public class ContextJsonConverterTest
    {
        [Fact]
        public void ReadJson_StringContext_ContextHasName()
        {
            var json = "{\"@context\":\"foo\",\"@type\":\"Thing\"}";

            var thing = JsonConvert.DeserializeObject<Thing>(json);

            Assert.NotNull(thing?.Context);
            Assert.Equal("foo", thing?.Context.Name);
            Assert.Null(thing?.Context.Language);
        }

        [Fact]
        public void ReadJson_ObjectContextWithName_ContextHasName()
        {
            var json = "{\"@context\":{\"name\":\"foo\"},\"@type\":\"Thing\"}";

            var thing = JsonConvert.DeserializeObject<Thing>(json);

            Assert.NotNull(thing?.Context);
            Assert.Equal("foo", thing?.Context.Name);
            Assert.Null(thing?.Context.Language);
        }

        [Fact]
        public void ReadJson_ObjectContextWithNameAndLanguage_ContextHasNameAndLanguage()
        {
            var json = "{\"@context\":{\"name\":\"foo\",\"@language\":\"en\"},\"@type\":\"Thing\"}";

            var thing = JsonConvert.DeserializeObject<Thing>(json);

            Assert.NotNull(thing?.Context);
            Assert.Equal("foo", thing?.Context.Name);
            Assert.Equal("en", thing?.Context.Language);
        }

        [Fact]
        public void WriteJson_StringContext_ContextHasName()
        {
            var json = new Thing().ToString();

            Assert.Equal("{\"@context\":\"https://schema.org\",\"@type\":\"Thing\"}", json);
        }

        [Fact]
        public void WriteJson_ObjectContextWithLanguage_ContextHasName()
        {
            var thing = new Thing();
            thing.Context.Language = "en";

            var json = thing.ToString();

            Assert.Equal("{\"@context\":{\"name\":\"https://schema.org\",\"@language\":\"en\"},\"@type\":\"Thing\"}", json);
        }
    }
}
