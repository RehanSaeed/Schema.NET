namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class OrganizationTest
    {
        // https://developers.google.com/search/docs/data-types/corporate-contacts
        [Fact]
        public void ToString_CorporateContactsGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var organization = new Organization()
            {
                AreaServed = "GB", // Recommended. Omit for global.
                ContactPoint = new ContactPoint() // Required
                {
                    AvailableLanguage = "English", // Recommended
                    ContactOption = ContactPointOption.TollFree, // Recommended
                    ContactType = "customer service", // Required
                    Telephone = "+1-401-555-1212" // Required
                },
                Url = new Uri("https://example.com") // Required
            };
            var expectedJson =
                @"{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"Organization\"," +
                    "\"url\":\"https://example.com\"," +
                    "\"areaServed\":\"GB\"," +
                    "\"contactPoint\":{" +
                        "\"@type\":\"ContactPoint\"," +
                        "\"availableLanguage\":\"English\"," +
                        "\"contactOption\":\"http://schema.org/TollFree\"," +
                        "\"contactType\":\"customer service\"," +
                        "\"telephone\":\"+1-401-555-1212\"" +
                    "}" +
                "}";

            var json = organization.ToString();

            Assert.Equal(expectedJson, json);
        }

        // https://developers.google.com/search/docs/data-types/logo
        [Fact]
        public void ToString_LogoGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var organization = new Organization()
            {
                Logo = new Uri("https://example.com/logo.png"), // Required
                Url = new Uri("https://example.com") // Required
            };
            var expectedJson =
                @"{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"Organization\"," +
                    "\"url\":\"https://example.com\"," +
                    "\"logo\":\"https://example.com/logo.png\"" +
                "}";

            var json = organization.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
