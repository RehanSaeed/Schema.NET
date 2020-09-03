namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/corporate-contacts
    // https://developers.google.com/search/docs/data-types/logo
    public class OrganizationTest
    {
        private readonly Organization organization = new Organization()
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

        private readonly string jsonHttp =
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
            Assert.Equal(this.organization.ToString(), JsonConvert.DeserializeObject<Organization>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.organization, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Organization>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }

        [Fact]
        public void Deserializing_OrganizationJsonLd_WithHttpSchemaOrg_ReturnsOrganization() =>
            Assert.Equal(
                this.organization.ToString().Replace("\"@context\":\"https://schema.org\"", "\"@context\":\"https://schema.org\"", StringComparison.Ordinal),
                JsonConvert.DeserializeObject<Organization>(this.jsonHttp, TestDefaults.DefaultJsonSerializerSettings).ToString());
    }
}
