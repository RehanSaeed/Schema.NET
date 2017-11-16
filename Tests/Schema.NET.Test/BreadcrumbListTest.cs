namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class BreadcrumbListTest
    {
        private readonly BreadcrumbList breadcrumbList = new BreadcrumbList()
        {
            ItemListElement = new List<ListItem>()
            {
                new ListItem()
                {
                    Position = 1,
                    Item = new Book()
                    {
                        Name = "Books",
                        Image = new Uri("http://example.com/images/icon-book.png")
                    }
                },
                new ListItem()
                {
                    Position = 2,
                    Item = new Person()
                    {
                        Name = "Authors",
                        Image = new Uri("http://example.com/images/icon-author.png")
                    }
                }
            }
        };

        private readonly string json =
        "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"BreadcrumbList\"," +
            "\"itemListElement\":[" +
                "{" +
                    "\"@type\":\"ListItem\"," +
                    "\"item\":{" + // Required
                        "\"@type\":\"Book\"," +
                        "\"name\":\"Books\"," + // Required
                        "\"image\":\"http://example.com/images/icon-book.png\"" + // Optional
                    "}," +
                    "\"position\":1" + // Required
                "}," +
                "{" +
                    "\"@type\":\"ListItem\"," +
                    "\"item\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"Authors\"," +
                        "\"image\":\"http://example.com/images/icon-author.png\"" +
                    "}," +
                    "\"position\":2" +
                "}" +
            "]" +
        "}";

        [Fact]
        public void ToString_BreadcrumbListGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            Assert.Equal(this.json, this.breadcrumbList.ToString());
        }

        [Fact]
        public void Deserializing_BreadcrumbListJsonLd_ReturnsBreadcrumbList()
        {
            Assert.Equal(this.breadcrumbList.ToString(), JsonConvert.DeserializeObject<BreadcrumbList>(this.json).ToString());
        }
    }
}
