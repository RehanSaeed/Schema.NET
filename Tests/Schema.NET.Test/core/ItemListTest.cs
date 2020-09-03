namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Xunit;

    public class ItemListTest
    {
        private readonly ItemList itemlist = new ItemList()
        {
            ItemListElement = new List<IListItem>() // Required
                {
                    new ListItem() // Required
                    {
                        Position = 1, // Required
                        Item = new Recipe() // Required
                        {
                            Name = "Recipe 1",
                        },
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Item = new Recipe()
                        {
                            Name = "Recipe 2",
                        },
                    },
                },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
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

        [Fact]
        public void Deserializing_ItemListJsonLd_ReturnsMatchingItemList()
        {
            Assert.Equal(this.itemlist.ToString(), JsonConvert.DeserializeObject<ItemList>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.itemlist, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<ItemList>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }

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
                        Url = new Uri("https://example.com/articles/1"), // Required
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Url = new Uri("https://example.com/articles/2"),
                    },
                },
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"ItemList\"," +
                    "\"itemListElement\":[" +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"url\":\"https://example.com/articles/1\"," +
                            "\"position\":1" +
                        "}," +
                        "{" +
                            "\"@type\":\"ListItem\"," +
                            "\"url\":\"https://example.com/articles/2\"," +
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
                            Name = "Recipe 1",
                        },
                    },
                    new ListItem()
                    {
                        Position = 2,
                        Item = new Recipe()
                        {
                            Name = "Recipe 2",
                        },
                    },
                },
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
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
                "\"@context\":\"https://schema.org\"," +
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
            var itemList = JsonConvert.DeserializeObject<ItemList>(json, TestDefaults.DefaultJsonSerializerSettings);

            Assert.Equal("ItemList", itemList.Type);
            Assert.True(itemList.ItemListElement.HasValue);
            Assert.Equal(2, itemList.ItemListElement.Count);
            var listItems = (List<IListItem>)itemList.ItemListElement;
            var things = (List<IThing>)itemList.ItemListElement;
            Assert.Empty(listItems);
            Assert.Equal(2, things.Count);
            var thing1 = things.First();
            var thing2 = things.Last();
            var listItem1 = (IListItem)thing1;
            var listItem2 = (IListItem)thing2;
            Assert.Equal(1, (int)listItem1.Position);
            Assert.Equal(2, (int)listItem2.Position);
            var recipe1 = Assert.IsType<Recipe>(listItem1.Item.Single());
            var recipe2 = Assert.IsType<Recipe>(listItem2.Item.Single());
            Assert.Equal("Recipe 1", recipe1.Name);
            Assert.Equal("Recipe 2", recipe2.Name);
        }
    }
}
