namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class ArticleTest
    {
        [Fact]
        public void ToString_ArticleGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var article = new Article()
            {
                MainEntityOfPage = new Uri("https://google.com/article"),
                Headline = "Article headline",
                Image = new ImageObject()
                {
                    Url = new Uri("https://google.com/thumbnail1.jpg"),
                    Height = "800",
                    Width = "800"
                }
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"NewsArticle\"," +
                    "\"mainEntityOfPage\":\"https://google.com/article\"" +
                    "\"headline\":\"Article headline\"," +
                    "\"image\":{" +
                        "\"@type\":\"ImageObject\"," +
                        "\"url\":\"https://google.com/thumbnail1.jpg\"," +
                        "\"height\":800," +
                        "\"width\":800" +
                    "}," +
                    "\"datePublished\":\"2015-02-05T08:00:00+08:00\"," +
                    "\"dateModified\":\"2015-02-05T09:20:00+08:00\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"John Doe\"" +
                    "}," +
                    "\"publisher\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Google\"," +
                        "\"logo\":{" +
                            "\"@type\":\"ImageObject\"," +
                            "\"url\":\"https://google.com/logo.jpg\"," +
                            "\"width\":600," +
                            "\"height\":60" +
                        "}" +
                    "}," +
                    "\"description\":\"A most wonderful article\"" +
                "}";

            var json = article.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
