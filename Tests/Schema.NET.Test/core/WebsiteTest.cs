namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class WebsiteTest
    {
        // https://developers.google.com/search/docs/data-types/sitelinks-searchbox
        [Fact]
        public void ToString_SiteLinksSearchBoxGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var website = new WebSite()
            {
                PotentialAction = new SearchAction() // Required
                {
                    Target = new Uri("https://example.com/search?&q={query}"), // Required
                    QueryInput = "required", // Required
                },
                Url = new Uri("https://example.com"), // Required
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"WebSite\"," +
                    "\"potentialAction\":{" +
                        "\"@type\":\"SearchAction\"," +
                        "\"target\":\"https://example.com/search?&q={query}\"," +
                        "\"query-input\":\"required\"" +
                    "}," +
                    "\"url\":\"https://example.com\"" +
                "}";

            var json = website.ToString();

            Assert.Equal(expectedJson, json);
        }

        // https://developers.google.com/search/docs/data-types/sitename
        [Fact]
        public void ToString_SiteNameGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var website = new WebSite()
            {
                AlternateName = "An Alternative Name", // Optional
                Name = "Your Site Name", // Required
                Url = new Uri("https://example.com"), // Required
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"WebSite\"," +
                    "\"name\":\"Your Site Name\"," +
                    "\"alternateName\":\"An Alternative Name\"," +
                    "\"url\":\"https://example.com\"" +
                "}";

            var json = website.ToString();

            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void Deserializing_WebSiteJsonLd_ReturnsWebSite()
        {
            var website = new WebSite()
            {
                PotentialAction = new SearchAction() // Required
                {
                    Target = new Uri("https://example.com/search?&q={query}"), // Required
                    QueryInput = "required", // Required
                },
                Url = new Uri("https://example.com"), // Required
            };

            var json =
            "{" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\":\"WebSite\"," +
                "\"potentialAction\":{" +
                    "\"@type\":\"SearchAction\"," +
                    "\"target\":\"https://example.com/search?&q={query}\"," +
                    "\"query-input\":\"required\"" +
                "}," +
                "\"url\":\"https://example.com\"" +
            "}";

            Assert.Equal(website.ToString(), JsonConvert.DeserializeObject<WebSite>(json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(website, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<WebSite>(json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
