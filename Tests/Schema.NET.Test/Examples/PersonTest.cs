namespace Schema.NET.Test.Examples;

using System;
using System.Collections.Generic;
using Xunit;

// https://developers.google.com/search/docs/data-types/social-profile-links
public class PersonTest
{
    private readonly Person person = new()
    {
        Name = "Name", // Required
        SameAs = new List<Uri>() // Required
            {
                new Uri("https://www.facebook.com/your-profile"),
                new Uri("https://instagram.com/yourProfile"),
                new Uri("https://www.linkedin.com/in/yourprofile"),
                new Uri("https://plus.google.com/your_profile"),
            },
        Url = new Uri("https://example.com"), // Required
    };

    private readonly string json = /*lang=json,strict*/
        """
        {
            "@context": "https://schema.org",
            "@type": "Person",
            "name": "Name",
            "sameAs": [
                "https://www.facebook.com/your-profile",
                "https://instagram.com/yourProfile",
                "https://www.linkedin.com/in/yourprofile",
                "https://plus.google.com/your_profile"
            ],
            "url": "https://example.com"
        }
        """;

    [Fact]
    public void ToString_SiteNameGoogleStructuredData_ReturnsExpectedJsonLd() =>
        Assert.Equal(this.json.MinifyJson(), this.person.ToString());

    [Fact]
    public void Deserializing_PersonJsonLd_ReturnsPerson()
    {
        Assert.Equal(this.person.ToString(), SchemaSerializer.DeserializeObject<Person>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.person), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<Person>(this.json)!));
    }
}
