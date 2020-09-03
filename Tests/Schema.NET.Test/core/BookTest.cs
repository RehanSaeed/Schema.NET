namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/books
    public class BookTest
    {
        private readonly Book book = new Book()
        {
            Id = new Uri("https://example.com/book/1"),
            Name = "The Catcher in the Rye",
            Author = new Person()
            {
                Name = "J.D. Salinger",
            },
            Url = new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"),
            WorkExample = new List<ICreativeWork>()
            {
                new Book()
                {
                    Isbn = "031676948",
                    BookEdition = "2nd Edition",
                    BookFormat = BookFormatType.Hardcover,
                    PotentialAction = new ReadAction()
                    {
                        Target = new EntryPoint()
                        {
                            UrlTemplate = "https://www.barnesandnoble.com/store/info/offer/0316769487?purchase=true",
                            ActionPlatform = new List<Uri>()
                            {
                                new Uri("https://schema.org/DesktopWebPlatform"),
                                new Uri("https://schema.org/IOSPlatform"),
                                new Uri("https://schema.org/AndroidPlatform"),
                            },
                        },
                        ExpectsAcceptanceOf = new Offer()
                        {
                            Price = 6.99M,
                            PriceCurrency = "USD",
                            EligibleRegion = new Country()
                            {
                                Name = "US",
                            },
                            Availability = ItemAvailability.InStock,
                        },
                    },
                },
                new Book()
                {
                    Isbn = "031676947",
                    BookEdition = "1st Edition",
                    BookFormat = BookFormatType.EBook,
                    PotentialAction = new ReadAction()
                    {
                        Target = new EntryPoint()
                        {
                            UrlTemplate = "https://www.barnesandnoble.com/store/info/offer/031676947?purchase=true",
                            ActionPlatform = new List<Uri>()
                            {
                                new Uri("https://schema.org/DesktopWebPlatform"),
                                new Uri("https://schema.org/IOSPlatform"),
                                new Uri("https://schema.org/AndroidPlatform"),
                            },
                        },
                        ExpectsAcceptanceOf = new Offer()
                        {
                            Price = 1.99M,
                            PriceCurrency = "USD",
                            EligibleRegion = new Country()
                            {
                                Name = "UK",
                            },
                            Availability = ItemAvailability.InStock,
                        },
                    },
                },
            },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"Book\"," +
            "\"@id\":\"https://example.com/book/1\"," +
            "\"name\":\"The Catcher in the Rye\"," +
            "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
            "\"author\":{" +
                "\"@type\":\"Person\"," +
                "\"name\":\"J.D. Salinger\"" +
            "}," +
            "\"workExample\":[" +
                "{" +
                    "\"@type\":\"Book\"," +
                    "\"potentialAction\":{" +
                        "\"@type\":\"ReadAction\"," +
                        "\"target\":{" +
                            "\"@type\":\"EntryPoint\"," +
                            "\"actionPlatform\":[" +
                                "\"https://schema.org/DesktopWebPlatform\"," +
                                "\"https://schema.org/IOSPlatform\"," +
                                "\"https://schema.org/AndroidPlatform\"" +
                            "]," +
                            "\"urlTemplate\":\"https://www.barnesandnoble.com/store/info/offer/0316769487?purchase=true\"" +
                        "}," +
                        "\"expectsAcceptanceOf\":{" +
                            "\"@type\":\"Offer\"," +
                            "\"availability\":\"https://schema.org/InStock\"," +
                            "\"eligibleRegion\":{" +
                                "\"@type\":\"Country\"," +
                                "\"name\":\"US\"" +
                            "}," +
                            "\"price\":6.99," +
                            "\"priceCurrency\":\"USD\"" +
                        "}" +
                    "}," +
                    "\"bookEdition\":\"2nd Edition\"," +
                    "\"bookFormat\":\"https://schema.org/Hardcover\"," +
                    "\"isbn\":\"031676948\"" +
                "}," +
                "{" +
                    "\"@type\":\"Book\"," +
                    "\"potentialAction\":{" +
                        "\"@type\":\"ReadAction\"," +
                        "\"target\":{" +
                            "\"@type\":\"EntryPoint\"," +
                            "\"actionPlatform\":[" +
                                "\"https://schema.org/DesktopWebPlatform\"," +
                                "\"https://schema.org/IOSPlatform\"," +
                                "\"https://schema.org/AndroidPlatform\"" +
                            "]," +
                            "\"urlTemplate\":\"https://www.barnesandnoble.com/store/info/offer/031676947?purchase=true\"" +
                        "}," +
                        "\"expectsAcceptanceOf\":{" +
                            "\"@type\":\"Offer\"," +
                            "\"availability\":\"https://schema.org/InStock\"," +
                            "\"eligibleRegion\":{" +
                                "\"@type\":\"Country\"," +
                                "\"name\":\"UK\"" +
                            "}," +
                            "\"price\":1.99," +
                            "\"priceCurrency\":\"USD\"" +
                        "}" +
                    "}," +
                    "\"bookEdition\":\"1st Edition\"," +
                    "\"bookFormat\":\"https://schema.org/EBook\"," +
                    "\"isbn\":\"031676947\"" +
                "}" +
            "]" +
        "}";

        [Fact]
        public void ToString_BookGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.book.ToString());

        [Fact]
        public void Deserializing_BookJsonLd_ReturnsMatchingBook()
        {
            Assert.Equal(this.book.ToString(), JsonConvert.DeserializeObject<Book>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.book, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Book>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }

        [Fact]
        public void Deserializing_BookJsonLd_ReturnsBook()
        {
            var book = JsonConvert.DeserializeObject<Book>(this.json, TestDefaults.DefaultJsonSerializerSettings);

            Assert.Equal("The Catcher in the Rye", book.Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)book.Url);
            Assert.True(book.Author.HasValue);

            List<IPerson> people = book.Author;
            var person = Assert.Single(people);
            Assert.Equal("J.D. Salinger", person.Name);

            List<ICreativeWork> creativeWorks = book.WorkExample;
            Assert.Equal(2, creativeWorks.Count);
            var books = creativeWorks.OfType<IBook>().ToList();
            Assert.Equal(2, books.Count);

            var book1 = books.First();
            Assert.Equal("2nd Edition", book1.BookEdition);
            Assert.Equal(BookFormatType.Hardcover, book1.BookFormat);
            Assert.Equal("031676948", book1.Isbn);

            var book2 = books.Last();
            Assert.Equal("1st Edition", book2.BookEdition);
            Assert.Equal(BookFormatType.EBook, book2.BookFormat);
            Assert.Equal("031676947", book2.Isbn);
        }

        [Fact]
        public void Deserializing_HasPersonAsAuthor_OrganizationIsNullAndHasPerson()
        {
            var json =
                "{" +
                    "\"@context\" : \"https://schema.org\"," +
                    "\"@type\" : \"Book\"," +
                    "\"author\" : [" +
                        "{" +
                            "\"@type\" : \"Person\"," +
                            "\"name\" : \"NameOfPerson1\"," +
                        "}," +
                    "]," +
                    "\"typicalAgeRange\" : \"14\"," +
                    "\"isbn\" : \"3333\"" +
                "}";
            var book = JsonConvert.DeserializeObject<Book>(json, TestDefaults.DefaultJsonSerializerSettings);

            Assert.Empty(book.Author.Value1);
            var person = Assert.Single(book.Author.Value2);
            Assert.Equal("NameOfPerson1", person.Name);
        }
    }
}
