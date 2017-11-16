namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class NewsArticleTest
    {
        private readonly NewsArticle article = new NewsArticle()
        {
            MainEntityOfPage = new Uri("https://google.com/article"), // Ignored
            Headline = "Article headline", // Recommended
            Image = new ImageObject() // Recommended
            {
                Url = new Uri("https://google.com/thumbnail1.jpg"), // Recommended
                Height = 800, // Recommended
                Width = 800 // Recommended
            },
            DatePublished = new DateTimeOffset(2015, 2, 5, 8, 0, 0, TimeSpan.Zero), // Ignored
            DateModified = new DateTimeOffset(2015, 2, 5, 9, 20, 0, TimeSpan.Zero), // Ignored
            Author = new Person() // Ignored
            {
                Name = "John Doe" // Ignored
            },
            Publisher = new Organization() // Ignored
            {
                Name = "Google",
                Logo = new ImageObject() // Ignored
                {
                    Url = new Uri("https://google.com/logo.jpg"), // Ignored
                    Height = 60, // Ignored
                    Width = 600 // Ignored
                }
            },
            Description = "A most wonderful article" // Ignored
        };

        private readonly string json =
        "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"NewsArticle\"," +
            "\"description\":\"A most wonderful article\"," +
            "\"image\":{" +
                "\"@type\":\"ImageObject\"," +
                "\"url\":\"https://google.com/thumbnail1.jpg\"," +
                "\"height\":800," +
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
                    "\"url\":\"https://google.com/logo.jpg\"," +
                    "\"height\":60," +
                    "\"width\":600" +
                "}" +
            "}" +
        "}";

        [Fact]
        public void ToString_ArticleGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            Assert.Equal(this.json, this.article.ToString());
        }

        [Fact]
        public void Deserializing_NewsArticleJsonLd_ReturnsNewsArticle()
        {
            Assert.Equal(this.article.ToString(), JsonConvert.DeserializeObject<NewsArticle>(this.json).ToString());
        }
    }
}
