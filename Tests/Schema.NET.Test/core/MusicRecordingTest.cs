namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class MusicRecordingTest
    {
        private readonly MusicRecording musicRecording = new MusicRecording()
        {
            Name = "2 + 2 = 5", // Required
            Identifier = "37kUGdEJJ7NaMl5LFW4EA4", // Recommended
            Image = new ImageObject() // Recommended
            {
                ContentUrl = new Uri("https://is4-ssl.mzstatic.com/image/thumb/Music69/v4/cc/1c/90/cc1c9039-c3ba-4256-e251-1687df46cb0a/cover.jpg/1400x1400bb.jpeg") // Required
            },
            SameAs = new Uri("https://music.apple.com/us/album/2-2-5/1097863576?i=1097863810"), // Recommended
            Url = new Uri("https://open.spotify.com/track/37kUGdEJJ7NaMl5LFW4EA4"), // Recommended
            DatePublished = new DateTime(2003, 5, 26), // Recommended
            IsFamilyFriendly = true, // Recommended
            Position = "1.1", // Recommended
            ByArtist = new MusicGroup() // Recommended
            {
                Name = "Radiohead", // Required
                Identifier = "4Z8W4fKeB5YxbusRsdQVPb" // Recommended
            },
            Duration = new TimeSpan(0, 0, 3, 19, 360), // Recommended
            InAlbum = new MusicAlbum() // Recommended
            {
                Name = "Hail To the Thief", // Required
                Identifier = "1oW3v5Har9mvXnGk0x4fHm" // Recommended
            },
            IsrcCode = "GBAYE0300801" // Recommended
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"MusicRecording\"," +
            "\"name\": \"2 + 2 = 5\"," +
            "\"identifier\": \"37kUGdEJJ7NaMl5LFW4EA4\"," +
            "\"image\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"ImageObject\"," +
                "\"contentUrl\": \"https://is4-ssl.mzstatic.com/image/thumb/Music69/v4/cc/1c/90/cc1c9039-c3ba-4256-e251-1687df46cb0a/cover.jpg/1400x1400bb.jpeg\"" +
            "}," +
            "\"sameAs\": \"https://music.apple.com/us/album/2-2-5/1097863576?i=1097863810\"," +
            "\"url\": \"https://open.spotify.com/track/37kUGdEJJ7NaMl5LFW4EA4\"," +
            "\"datePublished\": \"2003-05-26\"," +
            "\"isFamilyFriendly\": true," +
            "\"position\": \"1.1\"," +
            "\"byArtist\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"MusicGroup\"," +
                "\"name\": \"Radiohead\"," +
                "\"identifier\": \"4Z8W4fKeB5YxbusRsdQVPb\"" +
            "}," +
            "\"duration\": \"PT3M19.36S\"," +
            "\"inAlbum\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"MusicAlbum\"," +
                "\"name\": \"Hail To the Thief\"," +
                "\"identifier\": \"1oW3v5Har9mvXnGk0x4fHm\"" +
            "}," +
            "\"isrcCode\": \"GBAYE0300801\"" +
        "}";

        [Fact]
        public void Deserializing_MusicRecordingJsonLd_ReturnsMusicRecording()
        {
            Assert.Equal(this.musicRecording.ToString(), JsonConvert.DeserializeObject<MusicRecording>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.musicRecording, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<MusicRecording>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
