namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Xunit;

    public class BreadcrumbListTest
    {
        [Fact]
        public void ToString_BreadcrumbListGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var breadcrumbList = new BreadcrumbList()
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
            var expectedJson =
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

            var json = breadcrumbList.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
