namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class NewsArticleTest
    {
        [Fact]
        public void ToString_ArticleGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var article = new NewsArticle()
            {
                MainEntityOfPage = new Uri("https://google.com/article"),
                Headline = "Article headline",
                Image = new ImageObject()
                {
                    Url = new Uri("https://google.com/thumbnail1.jpg"),
                    Height = 800,
                    Width = 800
                },
                DatePublished = new DateTimeOffset(2015, 2, 5, 8, 0, 0, TimeSpan.Zero),
                DateModified = new DateTimeOffset(2015, 2, 5, 9, 20, 0, TimeSpan.Zero),
                Author = new Person()
                {
                    Name = "John Doe"
                },
                Publisher = new Organization()
                {
                    Name = "Google",
                    Logo = new ImageObject()
                    {
                        Url = new Uri("https://google.com/logo.jpg"),
                        Height = 60,
                        Width = 600
                    }
                },
                Description = "A most wonderful article"
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"NewsArticle\"," +
                    "\"description\":\"A most wonderful article\"," +
                    "\"image\":{" +
                        "\"@type\":\"ImageObject\"," +
                        "\"height\":800," +
                        "\"url\":\"https://google.com/thumbnail1.jpg\"," +
                        "\"width\":800" +
                    "}," +
                    "\"mainEntityOfPage\":\"https://google.com/article\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"John Doe\"" +
                    "}," +
                    "\"dateModified\":\"2015-02-05T09:20:00+00:00\"," +
                    "\"datePublished\":\"2015-02-05T08:00:00+00:00\"," +
                    "\"headline\":\"Article headline\"," +
                    "\"publisher\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Google\"," +
                        "\"logo\":{" +
                            "\"@type\":\"ImageObject\"," +
                            "\"height\":60," +
                            "\"url\":\"https://google.com/logo.jpg\"," +
                            "\"width\":600" +
                        "}" +
                    "}" +
                "}";

            var json = article.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
