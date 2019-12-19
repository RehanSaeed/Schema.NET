namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class MusicGroupTest
    {
        private readonly MusicGroup musicGroup = new MusicGroup()
        {
            Name = "Radiohead", // Required
            Identifier = "4Z8W4fKeB5YxbusRsdQVPb", // Recommended
            Image = new ImageObject() // Recommended
            {
                ContentUrl = new Uri("https://i.scdn.co/image/afcd616e1ef2d2786f47b3b4a8a6aeea24a72adc"), // Required
            },
            SameAs = new Uri("https://music.apple.com/us/artist/radiohead/657515"), // Recommended
            Url = new Uri("https://open.spotify.com/artist/4Z8W4fKeB5YxbusRsdQVPb"), // Recommended
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"MusicGroup\"," +
            "\"name\": \"Radiohead\"," +
            "\"identifier\": \"4Z8W4fKeB5YxbusRsdQVPb\"," +
            "\"image\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"ImageObject\"," +
                "\"contentUrl\": \"https://i.scdn.co/image/afcd616e1ef2d2786f47b3b4a8a6aeea24a72adc\"" +
            "}," +
            "\"sameAs\": \"https://music.apple.com/us/artist/radiohead/657515\"," +
            "\"url\": \"https://open.spotify.com/artist/4Z8W4fKeB5YxbusRsdQVPb\"" +
        "}";

        [Fact]
        public void Deserializing_MusicGroupJsonLd_ReturnsMusicGroup()
        {
            Assert.Equal(this.musicGroup.ToString(), JsonConvert.DeserializeObject<MusicGroup>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.musicGroup, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<MusicGroup>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
