namespace Schema.NET.Test.Examples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class BreadcrumbListTest
    {
        private readonly BreadcrumbList breadcrumbList = new()
        {
            ItemListElement = new List<IListItem>()
            {
                new ListItem()
                {
                    Position = 1,
                    Item = new Book()
                    {
                        Id = new Uri("https://example.com/books"),
                        Name = "Books",
                        Image = new Uri("https://example.com/images/icon-book.png"),
                    },
                },
                new ListItem()
                {
                    Position = 2,
                    Item = new Person()
                    {
                        Id = new Uri("https://example.com/books/authors"),
                        Name = "Authors",
                        Image = new Uri("https://example.com/images/icon-author.png"),
                    },
                },
            },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"BreadcrumbList\"," +
            "\"itemListElement\":[" +
                "{" +
                    "\"@type\":\"ListItem\"," +
                    "\"item\":{" + // Required
                        "\"@type\":\"Book\"," +
                        "\"@id\":\"https://example.com/books\"," + // Required
                        "\"name\":\"Books\"," + // Required
                        "\"image\":\"https://example.com/images/icon-book.png\"" + // Optional
                    "}," +
                    "\"position\":1" + // Required
                "}," +
                "{" +
                    "\"@type\":\"ListItem\"," +
                    "\"item\":{" +
                        "\"@type\":\"Person\"," +
                        "\"@id\":\"https://example.com/books/authors\"," + // Required
                        "\"name\":\"Authors\"," +
                        "\"image\":\"https://example.com/images/icon-author.png\"" +
                    "}," +
                    "\"position\":2" +
                "}" +
            "]" +
        "}";

        [Fact]
        public void Deserializing_BreadcrumbListJsonLd_ReturnsMatchingBreadcrumbList()
        {
            Assert.Equal(this.breadcrumbList.ToString(), SchemaSerializer.DeserializeObject<BreadcrumbList>(this.json)!.ToString());
            Assert.Equal(SchemaSerializer.SerializeObject(this.breadcrumbList), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<BreadcrumbList>(this.json)!));
        }

        [Fact]
        public void Deserializing_BreadcrumbListJsonLd_ReturnsBreadcrumbList()
        {
            var breadcrumbList = SchemaSerializer.DeserializeObject<BreadcrumbList>(this.json)!;

            List<IThing> things = breadcrumbList.ItemListElement;
            List<IListItem> listItems = breadcrumbList.ItemListElement;
            Assert.Equal(2, things.Count);
            Assert.Empty(listItems);
            var thing1 = things.First();
            var thing2 = things.Last();
            var listItem1 = (IListItem)thing1;
            var listItem2 = (IListItem)thing2;
            Assert.Equal(1, (int)listItem1.Position!);
            Assert.Equal(2, (int)listItem2.Position!);
            var book = listItem1.Item.OfType<IBook>().First()!;
            Assert.Equal("Books", book.Name);
            Assert.Equal(new Uri("https://example.com/images/icon-book.png"), (Uri)book.Image!);
            var person = listItem2.Item.OfType<IPerson>().First();
            Assert.Equal("Authors", person.Name);
            Assert.Equal(new Uri("https://example.com/images/icon-author.png"), (Uri)person.Image!);
        }
    }
}
