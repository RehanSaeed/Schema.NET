namespace Schema.NET.Test.Examples
{
    using System;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/articles
    public class VideoObjectTest
    {
        private readonly VideoObject videoObject = new()
        {
            Name = "Title", // Required
            Description = "Video description", // Required
            ThumbnailUrl = new Uri("https://www.example.com/thumbnail.jpg"), // Required
            Expires = new DateTime(2016, 2, 5), // Recommended
            UploadDate = new DateTime(2015, 2, 5), // Required
            Duration = new TimeSpan(0, 1, 33), // Recommended
            Publisher = new Organization()
            {
                Name = "Example Publisher", // Required
                Logo = new ImageObject() // Required
                {
                    Height = 60, // Required
                    Url = new Uri("https://example.com/logo.jpg"), // Required
                    Width = 600, // Required
                },
            },
            ContentUrl = new Uri("https://www.example.com/video123.flv"), // Recommended
            EmbedUrl = new Uri("https://www.example.com/videoplayer.swf?video=123"), // Recommended
            InteractionStatistic = new InteractionCounter()
            {
                UserInteractionCount = 2347, // Recommended
            },
        };

        private readonly string json =
            "{" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\":\"VideoObject\"," +
                "\"name\":\"Title\"," +
                "\"description\":\"Video description\"," +
                "\"expires\":\"2016-02-05\"," +
                "\"interactionStatistic\":{" +
                    "\"@type\":\"InteractionCounter\"," +
                    "\"userInteractionCount\":2347" +
                "}," +
                "\"publisher\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"Example Publisher\"," +
                    "\"logo\":{" +
                        "\"@type\":\"ImageObject\"," +
                        "\"url\":\"https://example.com/logo.jpg\"," +
                        "\"height\":60," +
                        "\"width\":600" +
                    "}" +
                "}," +
                "\"thumbnailUrl\":\"https://www.example.com/thumbnail.jpg\"," +
                "\"contentUrl\":\"https://www.example.com/video123.flv\"," +
                "\"duration\":\"PT1M33S\"," +
                "\"embedUrl\":\"https://www.example.com/videoplayer.swf?video=123\"," +
                "\"uploadDate\":\"2015-02-05\"" +
            "}";

        [Fact]
        public void ToString_VideoGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.videoObject.ToString());

        [Fact]
        public void Deserializing_VideoObjectJsonLd_ReturnsVideoObject()
        {
            Assert.Equal(this.videoObject.ToString(), SchemaSerializer.DeserializeObject<VideoObject>(this.json)!.ToString());
            Assert.Equal(SchemaSerializer.SerializeObject(this.videoObject), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<VideoObject>(this.json)!));
        }
    }
}
