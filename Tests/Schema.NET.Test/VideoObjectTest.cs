namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class VideoObjectTest
    {
        // https://developers.google.com/search/docs/data-types/articles
        [Fact]
        public void ToString_VideoGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var videoObject = new VideoObject()
            {
                Name = "Title", // Required
                Description = "Video description", // Required
                ThumbnailUrl = new Uri("https://www.example.com/thumbnail.jpg"), // Required
                Expires = new DateTimeOffset(2016, 2, 5, 8, 0, 0, TimeSpan.Zero), // Recommended
                UploadDate = new DateTimeOffset(2015, 2, 5, 8, 0, 0, TimeSpan.Zero), // Required
                Duration = new TimeSpan(0, 1, 33), // Recommended
                Publisher = new Organization()
                {
                    Name = "Example Publisher", // Required
                    Logo = new ImageObject() // Required
                    {
                        Height = 60, // Required
                        Url = new Uri("https://example.com/logo.jpg"), // Required
                        Width = 600 // Required
                    }
                },
                ContentUrl = new Uri("https://www.example.com/video123.flv"), // Recommended
                EmbedUrl = new Uri("https://www.example.com/videoplayer.swf?video=123"), // Recommended
                InteractionStatistic = new InteractionCounter()
                {
                    UserInteractionCount = 2347 // Recommended
                },
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"VideoObject\"," +
                    "\"name\":\"Title\"," +
                    "\"description\":\"Video description\"," +
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
                    "\"expires\":\"2016-02-05T08:00:00+00:00\"," +
                    "\"uploadDate\":\"2015-02-05T08:00:00+00:00\"" +
                "}";

            var json = videoObject.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
