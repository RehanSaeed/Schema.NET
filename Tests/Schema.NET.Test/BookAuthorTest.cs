namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class BookAuthorTest
    {
        private readonly Book book = new Book()
        {
            Author = new List<Person>()
            {
                new Person()
                {
                    Name = "NameOfPerson1",
                    JobTitle = "jobTitle",
                    Email = "email@gmail.com"
                },
                new Person()
                {
                    Name = "NameOfPerson2",
                    JobTitle = "someJobTitle",
                    Email = "car.kreml@yandex.ru"
                }
            },
            Contributor = new List<Person>()
            {
                new Person()
                {
                    Name = "Contributor1",
                    JobTitle = "Дизайн"
                },
                new Person()
                {
                    Name = "Contributor2",
                    JobTitle = "Верстка"
                }
            },
            TypicalAgeRange = "14",
            Isbn = "3333"
        };

        private readonly string json =
        "{" +
            "\"@context\" : \"http://schema.org\"," +
            "\"@type\" : \"Book\"," +
            "\"author\" : [" +
                "{" +
                    "\"@type\" : \"Person\"," +
                    "\"name\" : \"NameOfPerson1\"," +
                    "\"email\" : \"email@gmail.com\"," +
                    "\"jobTitle\" : \"jobTitle\"" +
                "}," +
                "{" +
                    "\"@type\" : \"Person\"," +
                    "\"name\" : \"NameOfPerson1\"," +
                    "\"email\" : \"car.kreml@yandex.ru\"," +
                    "\"jobTitle\" : \"someJobTitle\"" +
                "}" +
            "]," +
            "\"contributor\": [" +
                "{" +
                    "\"@type\" : \"Person\"," +
                    "\"name\" : \"Contributor1\"," +
                    "\"jobTitle\" : \"Дизайн\"" +
                "}," +
                "{" +
                    "\"@type\" : \"Person\"," +
                    "\"name\" : \"Contributor2\"," +
                    "\"jobTitle\" : \"Верстка\"" +
                "}" +
            "]," +
            "\"typicalAgeRange\" : \"14\"," +
            "\"isbn\" : \"3333\"" +
        "}";

        [Fact]
        public void Deserializing_ReturnsCorrectBookAuthor_Type_Organization() =>
            Assert.Equal(this.book.Author.Value.Value1, JsonConvert.DeserializeObject<Book>(this.json).Author.Value.Value1);

        [Fact]
        public void Deserializing_ReturnsCorrectBookAuthor_Type_Person() =>
            Assert.Equal(this.book.Author.Value.Value2, JsonConvert.DeserializeObject<Book>(this.json).Author.Value.Value2);
    }
}
