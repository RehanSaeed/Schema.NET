namespace Schema.NET.Test.Examples;

using System;
using Xunit;

// https://developers.google.com/search/docs/data-types/corporate-contacts
// https://developers.google.com/search/docs/data-types/logo
public class OrganizationTest
{
    private readonly Organization organization = new()
    {
        AreaServed = "GB", // Recommended. Omit for global.
        ContactPoint = new ContactPoint() // Required
        {
            AvailableLanguage = "English", // Recommended
            ContactOption = ContactPointOption.TollFree, // Recommended
            ContactType = "customer service", // Required
            Telephone = "+1-401-555-1212", // Required
        },
        Url = new Uri("https://example.com"), // Required
        Logo = new Uri("https://example.com/logo.png"),
    };

    private readonly string json =
    @"{" +
        "\"@context\":\"https://schema.org\"," +
        "\"@type\":\"Organization\"," +
        "\"url\":\"https://example.com\"," +
        "\"areaServed\":\"GB\"," +
        "\"contactPoint\":{" +
            "\"@type\":\"ContactPoint\"," +
            "\"availableLanguage\":\"English\"," +
            "\"contactOption\":\"https://schema.org/TollFree\"," +
            "\"contactType\":\"customer service\"," +
            "\"telephone\":\"+1-401-555-1212\"" +
        "}," +
        "\"logo\":\"https://example.com/logo.png\"" +
    "}";

    [Fact]
    public void ToString_CorporateContactsGoogleStructuredData_ReturnsExpectedJsonLd() =>
        Assert.Equal(this.json, this.organization.ToString());

    [Fact]
    public void Deserializing_OrganizationJsonLd_ReturnsOrganization()
    {
        Assert.Equal(this.organization.ToString(), SchemaSerializer.DeserializeObject<Organization>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.organization), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<Organization>(this.json)!));
    }
}
