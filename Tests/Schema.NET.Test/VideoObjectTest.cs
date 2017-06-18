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
                Name = "Title",
                Description = "Video description",
                ThumbnailUrl = new Uri("https://www.example.com/thumbnail.jpg"),
                UploadDate = new DateTimeOffset(2015, 2, 5, 8, 0, 0, TimeSpan.Zero),
                Duration = new TimeSpan(0, 1, 33),
                Publisher = new Organization()
                {
                    Name = "Example Publisher",
                    Logo = new ImageObject()
                    {
                        Height = 60,
                        Url = new Uri("https://example.com/logo.jpg"),
                        Width = 600
                    }
                },
                ContentUrl = new Uri("https://www.example.com/video123.flv"),
                EmbedUrl = new Uri("https://www.example.com/videoplayer.swf?video=123"),
                InteractionStatistic = new InteractionCounter()
                {
                    UserInteractionCount = 2347
                }
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"VideoObject\"," +
                    "\"description\":\"Video description\"," +
                    "\"contentUrl\":\"https://www.example.com/video123.flv\"," +
                    "\"duration\":\"PT1M33S\"," +
                    "\"embedUrl\":\"https://www.example.com/videoplayer.swf?video=123\"," +
                    "\"name\":\"Title\"," +
                    "\"uploadDate\":\"2015-02-05T08:00:00+00:00\"," +
                    "\"interactionStatistic\":{" +
                        "\"@type\":\"InteractionCounter\"," +
                        "\"userInteractionCount\":2347" +
                    "}," +
                    "\"publisher\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Example Publisher\"," +
                        "\"logo\":{" +
                            "\"@type\":\"ImageObject\"," +
                            "\"height\":60," +
                            "\"url\":\"https://example.com/logo.jpg\"," +
                            "\"width\":600" +
                        "}" +
                    "}," +
                    "\"thumbnailUrl\":\"https://www.example.com/thumbnail.jpg\"" +
                "}";

            var json = videoObject.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
