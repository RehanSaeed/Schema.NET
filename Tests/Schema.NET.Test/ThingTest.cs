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

        [Fact]
        public void Equality_AreEqual_Default() => CompareEqual(new Thing(), new Thing());

        [Fact]
        public void Equality_AreEqual_SinglePropertyValue() => CompareEqual(
            new Thing
            {
                Name = "Custom Name"
            }, new Thing
            {
                Name = "Custom Name"
            });

        [Fact]
        public void Equality_AreEqual_MultiPropertyValue() => CompareEqual(
            new Thing
            {
                Name = "Custom Name",
                Url = new Uri("https://schema.net")
            }, new Thing
            {
                Name = "Custom Name",
                Url = new Uri("https://schema.net")
            });

        [Fact]
        public void Equality_AreNotEqual_Null() => CompareNotEqual(
            new Thing
            {
                Name = "A"
            }, null);

        [Fact]
        public void Equality_AreNotEqual_SinglePropertyValue() => CompareNotEqual(
            new Thing
            {
                Name = "A"
            }, new Thing
            {
                Name = "B"
            });

        [Fact]
        public void Equality_AreNotEqual_MultiPropertyValue() => CompareNotEqual(
            new Thing
            {
                Name = "A",
                Url = new Uri("https://schema.net")
            }, new Thing
            {
                Name = "B",
                Url = new Uri("https://schema.net/Thing")
            });

        private static void CompareEqual<T>(T a, T b)
        {
            Assert.Equal(a.GetHashCode(), b.GetHashCode());
            Assert.True(a.Equals(b));
        }

        private static void CompareNotEqual<T>(T a, T b)
        {
            Assert.NotEqual(a.GetHashCode(), b.GetHashCode());
            Assert.False(a.Equals(b));
        }
    }
}
