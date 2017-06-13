namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class WebsiteTest
    {
        [Fact]
        public void ToString_Website_MatchesExpectedJson()
        {
            var website = new WebSite()
            {
                PotentialAction = new SearchAction()
                {
                    TargetURL = new Uri("http://example.com/search?&q={query}"),
                    QueryInputText = "required"
                },
                Url = new Uri("https://example.com")
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"WebSite\"," +
                    "\"potentialAction\":{" +
                        "\"@type\":\"SearchAction\"," +
                        "\"query-input\":\"required\"," +
                        "\"target\":\"http://example.com/search?&q={query}\"" +
                    "}," +
                    "\"url\":\"https://example.com\"" +
                "}";

            var json = website.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
