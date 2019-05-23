namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
                ItemListElement = new List<IListItem>() // Required
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
                ItemListElement = new List<IListItem>() // Required
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
            var itemList = JsonConvert.DeserializeObject<ItemList>(json);

            Assert.Equal("ItemList", itemList.Type);
            Assert.True(itemList.ItemListElement.HasValue);
            Assert.Equal(4, itemList.ItemListElement.Value.Count);
            var listItems = (List<IListItem>)itemList.ItemListElement.Value;
            var things = (List<IThing>)itemList.ItemListElement.Value;
            Assert.Equal(2, listItems.Count);
            Assert.Equal(2, things.Count);
            var listItem1 = listItems.First();
            var listItem2 = listItems.Last();
            var thing1 = things.First();
            var thing2 = things.Last();
            var thingListItem1 = Assert.IsType<ListItem>(thing1);
            var thingListItem2 = Assert.IsType<ListItem>(thing2);
            Assert.Equal(1, listItem1.Position);
            Assert.Equal(2, listItem2.Position);
            Assert.Equal(1, thingListItem1.Position);
            Assert.Equal(2, thingListItem2.Position);
            var recipe1 = Assert.IsType<Recipe>(listItem1.Item.Single());
            var recipe2 = Assert.IsType<Recipe>(listItem2.Item.Single());
            var recipe3 = Assert.IsType<Recipe>(thingListItem1.Item.Single());
            var recipe4 = Assert.IsType<Recipe>(thingListItem2.Item.Single());
            Assert.Equal("Recipe 1", recipe1.Name);
            Assert.Equal("Recipe 2", recipe2.Name);
            Assert.Equal("Recipe 1", recipe3.Name);
            Assert.Equal("Recipe 2", recipe4.Name);
        }
    }
}
