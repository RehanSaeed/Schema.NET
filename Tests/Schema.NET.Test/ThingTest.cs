namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class ThingTest
    {
        private readonly Thing thing = new Thing()
        {
            Name = "New Object",
            Description = "This is the description of a new object we can't deserialize",
            Image = new Uri("https://example.com/image.jpg")
        };

        private readonly string json =
            "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"NewObject\"," +
            "\"name\":\"New Object\"," +
            "\"description\":\"This is the description of a new object we can't deserialize\"," +
            "\"image\":\"https://example.com/image.jpg\"," +
            "\"someProperty\":\"not supported\"" +
            "}";

        [Fact]
        public void Deserializing_NewObjectJsonLd_ReturnsThing() =>
            Assert.Equal(
                this.thing.ToString(),
                JsonConvert.DeserializeObject<Thing>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
    }
}
