
namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class ItemListTest
    {
        // https://developers.google.com/search/docs/guides/mark-up-listings
        [Fact]
        public void ToString_CarouselSummaryPageSearchBoxGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            // All items in the list must be of the same type. Recipe, Film, Course, Article, Recipe are supported.
            var itemList = new ItemList()
            {
                ItemListElement = new List<ListItem>() // Required
                {
                    new ListItem() // Required
                    {
                        Position = 1, // Required
                        Url = new Uri("http://example.com/articles/1") // Required
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
                            "\"url\":\"http://example.com/articles/1\"," +
                            "\"position\":1" +
                        "}," +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"url\":\"http://example.com/articles/2\"," +
                            "\"position\":2" +
                        "}" +
                    "]" +
                "}";

            var json = itemList.ToString();

            Assert.Equal(expectedJson, json);
        }

        // https://developers.google.com/search/docs/guides/mark-up-listings
        [Fact]
        public void ToString_CarouselAllInOnePageSearchBoxGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            // All items in the list must be of the same type. Recipe, Film, Course, Article, Recipe are supported.
            var itemList = new ItemList()
            {
                ItemListElement = new List<ListItem>() // Required
                {
                    new ListItem() // Required
                    {
                        Position = 1, // Required
                        Item = new Recipe() // Required
                        {
                            Name = "Recipe 1"
                        }
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Item = new Recipe()
                        {
                            Name = "Recipe 2"
                        }
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
                            "\"item\":{" +
                                "\"@type\":\"Recipe\"," +
                                "\"name\":\"Recipe 1\"" +
                            "}," +
                            "\"position\":1" +
                        "}," +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"item\":{" +
                                "\"@type\":\"Recipe\"," +
                                "\"name\":\"Recipe 2\"" +
                            "}," +
                            "\"position\":2" +
                        "}" +
                    "]" +
                "}";

            var json = itemList.ToString();

            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void Deserializing_ItemListJsonLd_ReturnsItemList()
        {
            // All items in the list must be of the same type. Recipe, Film, Course, Article, Recipe are supported.
            var itemList = new ItemList()
            {
                ItemListElement = new List<ListItem>() // Required
                {
                    new ListItem() // Required
                    {
                        Position = 1, // Required
                        Item = new Recipe() // Required
                        {
                            Name = "Recipe 1"
                        }
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Item = new Recipe()
                        {
                            Name = "Recipe 2"
                        }
                    }
                }
            };

            var json =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"ItemList\"," +
                "\"itemListElement\":[" +
                    "{" +
                        "\"@type\":\"ListItem\"," +
                        "\"item\":{" +
                            "\"@type\":\"Recipe\"," +
                            "\"name\":\"Recipe 1\"" +
                        "}," +
                        "\"position\":1" +
                    "}," +
                    "{" +
                        "\"@type\":\"ListItem\"," +
                        "\"item\":{" +
                            "\"@type\":\"Recipe\"," +
                            "\"name\":\"Recipe 2\"" +
                            "}," +
                        "\"position\":2" +
                    "}" +
                "]" +
            "}";

            Assert.Equal(itemList.ToString(), JsonConvert.DeserializeObject<ItemList>(json).ToString());
        }
    }
}
