namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Xunit;

    public class ItemListTest
    {
        // https://developers.google.com/search/docs/guides/mark-up-listings
        [Fact]
        public void ToString_CarouselsSearchBoxGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            // All items in the list must be of the same type. Recipe, Film, Course, Article, Recipe are supported.
            var itemList = new ItemList()
            {
                ItemListElement = new List<ListItem>()
                {
                    new ListItem()
                    {
                        Position = 1,
                        Url = new Uri("http://example.com/articles/1")
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Url = new Uri("http://example.com/articles/2")
                    }
                }
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"ItemList\"," +
                    "\"itemListElement\":[" +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"position\":1," +
                            "\"url\":\"http://example.com/articles/1\"" +
                        "}," +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"position\":2," +
                            "\"url\":\"http://example.com/articles/2\"" +
                        "}" +
                    "]" +
                "}";

            var json = itemList.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
