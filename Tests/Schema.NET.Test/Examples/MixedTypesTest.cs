namespace Schema.NET.Test.Examples;

using System;
using System.Collections.Generic;
using Xunit;

public class MixedTypesTest
{
    private readonly Book book =
        new()
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

    private readonly string json = /*lang=json,strict*/
        """
        {
            "@context": "https://schema.org",
            "@type": "Book",
            "@id": "https://example.com/book/1",
            "author": [
                {
                    "@type": "Organization",
                    "name": "Penguin"
                },
                {
                    "@type": "Person",
                    "name": "J.D. Salinger"
                }
            ]
        }
        """;

    [Fact]
    public void Deserializing_WithCollectionOfMixedTypes_ReturnsMatchingObject()
    {
        Assert.Equal(this.book.ToString(), SchemaSerializer.DeserializeObject<Book>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.book), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<Book>(this.json)!));
    }

    [Fact]
    public void DeserializeObject_WithCollectionOfMixedTypes_ReturnsObjectWithBothTypes()
    {
        var book = SchemaSerializer.DeserializeObject<Book>(this.json)!;

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
}
