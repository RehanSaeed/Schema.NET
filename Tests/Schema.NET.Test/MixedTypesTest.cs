namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class MixedTypesTest
    {
        private readonly Book book =
            new Book()
            {
                Id = new Uri("https://example.com/book/1"),
                Author = new List<object>()
                {
                    new Organization()
                    {
                        Name = "Penguin",
                    },
                    new Person()
                    {
                        Name = "J.D. Salinger",
                    },
                },
            };

        private readonly string json =
            "{" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\":\"Book\"," +
                "\"@id\":\"https://example.com/book/1\"," +
                "\"author\":[" +
                    "{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Penguin\"" +
                    "}," +
                    "{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}" +
                "]" +
            "}";

        [Fact]
        public void DeserializeObject_WithCollectionOfMixedTypes_ReturnsObjectWithBothTypes()
        {
            var book = JsonConvert.DeserializeObject<Book>(this.json, TestDefaults.DefaultJsonSerializerSettings);

            Assert.True(book.Author.HasValue);
            Assert.True(book.Author.HasValue1);
            Assert.True(book.Author.HasValue2);
            Assert.True(book.Author.Value1.HasOne);
            Assert.True(book.Author.Value2.HasOne);
            Assert.False(book.Author.Value1.HasMany);
            Assert.False(book.Author.Value2.HasMany);
            Assert.Single(book.Author.Value1);
            Assert.Single(book.Author.Value2);

            List<IPerson> people = book.Author;
            List<IOrganization> organizations = book.Author;

            var person = Assert.Single(people);
            var organization = Assert.Single(organizations);
            Assert.Equal("J.D. Salinger", person.Name);
            Assert.Equal("Penguin", organization.Name);
        }

        [Fact]
        public void ToString_Book_MatchesExpectedJson() =>
            Assert.Equal(this.json, this.book.ToString());

        [Fact]
        public void ToString_SerializesBankAccountTypeFromStringAndUri_BankAccountTypeHasTwoValues()
        {
            var bankAccount = new BankAccount()
            {
                BankAccountType = new List<object>()
                {
                    "https://example.com/1",
                    new Uri("https://example.com/2"),
                },
            };
            var json =
                @"{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"BankAccount\"," +
                    "\"bankAccountType\":[" +
                        "\"https://example.com/1\"," +
                        "\"https://example.com/2\"" +
                    "]" +
                "}";
            Assert.Equal(json, bankAccount.ToString());
        }
    }
}
