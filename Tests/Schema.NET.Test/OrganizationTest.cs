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
                    "\"areaServed\":\"GB\"," +
                    "\"contactPoint\":{" +
                        "\"@type\":\"ContactPoint\"," +
                        "\"availableLanguage\":\"English\"," +
                        "\"contactOption\":\"TollFree\"," +
                        "\"contactType\":\"customer service\"," +
                        "\"telephone\":\"+1-401-555-1212\"" +
                    "}," +
                    "\"url\":\"https://example.com\"" +
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

        [Fact]
        public void ToString_TestAllPrimitiveTypes_ReturnsExpectedJsonLd()
        {
            var organization = new Organization()
            {
                Address = new PostalAddress()
                {
                    ContactOption = ContactPointOption.HearingImpairedSupported
                },
                DissolutionDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.FromHours(1)),
                ContactPoint = new ContactPoint()
                {
                    Telephone = "+1-401-555-1212",
                    ContactType = "Customer Service"
                },
                Url = new Uri("https://example.com")
            };
            var expectedJson =
                @"{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"Organization\"," +
                    "\"address\":{" +
                        "\"@type\":\"PostalAddress\"," +
                        "\"contactOption\":\"HearingImpairedSupported\"" +
                    "}," +
                    "\"contactPoint\":{" +
                        "\"@type\":\"ContactPoint\"," +
                        "\"contactType\":\"Customer Service\"," +
                        "\"telephone\":\"+1-401-555-1212\"" +
                    "}," +
                    "\"dissolutionDate\":\"2000-01-01T00:00:00+01:00\"," +
                    "\"url\":\"https://example.com\"" +
                "}";

            var json = organization.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
