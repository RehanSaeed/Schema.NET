namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Xunit;

    public class BreadcrumbListTest
    {
        private readonly BreadcrumbList breadcrumbList = new BreadcrumbList()
        {
            ItemListElement = new List<IListItem>()
            {
                new ListItem()
                {
                    Position = 1,
                    Item = new Book()
                    {
                        Id = new Uri("http://example.com/books"),
                        Name = "Books",
                        Image = new Uri("http://example.com/images/icon-book.png")
                    }
                },
                new ListItem()
                {
                    Position = 2,
                    Item = new Person()
                    {
                        Id = new Uri("http://example.com/books/authors"),
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
                        "\"@id\":\"http://example.com/books\"," + // Required
                        "\"name\":\"Books\"," + // Required
                        "\"image\":\"http://example.com/images/icon-book.png\"" + // Optional
                    "}," +
                    "\"position\":1" + // Required
                "}," +
                "{" +
                    "\"@type\":\"ListItem\"," +
                    "\"item\":{" +
                        "\"@type\":\"Person\"," +
                        "\"@id\":\"http://example.com/books/authors\"," + // Required
                        "\"name\":\"Authors\"," +
                        "\"image\":\"http://example.com/images/icon-author.png\"" +
                    "}," +
                    "\"position\":2" +
                "}" +
            "]" +
        "}";

        [Fact]
        public void ToString_BreadcrumbListGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.breadcrumbList.ToString());

        [Fact]
        public void Deserializing_BreadcrumbListJsonLd_ReturnsMatchingBreadcrumbList()
        {
            Assert.Equal(this.breadcrumbList.ToString(), JsonConvert.DeserializeObject<BreadcrumbList>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.breadcrumbList, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<BreadcrumbList>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }

        [Fact]
        public void Deserializing_BreadcrumbListJsonLd_ReturnsBreadcrumbList()
        {
            var breadcrumbList = JsonConvert.DeserializeObject<BreadcrumbList>(this.json, TestDefaults.DefaultJsonSerializerSettings);

            List<IListItem> listItems = breadcrumbList.ItemListElement;
            Assert.Equal(2, listItems.Count);
            var listItem1 = listItems.First();
            var listItem2 = listItems.Last();
            Assert.Equal(1, listItem1.Position);
            Assert.Equal(2, listItem2.Position);
            var book = listItem1.Item.OfType<IBook>().FirstOrDefault();
            Assert.NotNull(book);
            Assert.Equal("Books", book.Name);
            Assert.Equal(new Uri("http://example.com/images/icon-book.png"), (Uri)book.Image);
            var person = listItem2.Item.OfType<IPerson>().FirstOrDefault();
            Assert.NotNull(person);
            Assert.Equal("Authors", person.Name);
            Assert.Equal(new Uri("http://example.com/images/icon-author.png"), (Uri)person.Image);
        }
    }
}
