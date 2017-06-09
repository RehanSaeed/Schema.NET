namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class OrganizationTest
    {
        [Fact]
        public void ToString_Default_OutputsJsonLd()
        {
            var organization = new Organization()
            {
                DissolutionDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.FromHours(1)),
                ContactPoint = new ContactPoint()
                {
                    Telephone = "+1-401-555-1212",
                    ContactType = "customer service"
                },
                Url = new Uri("http://www.your-company-site.com")
            };
            var expectedJson =
                @"{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"Organization\"," +
                    "\"contactPoint\":{" +
                        "\"@type\":\"ContactPoint\"," +
                        "\"contactType\":\"customer service\"," +
                        "\"telephone\":\"+1-401-555-1212\"" +
                    "}," +
                    "\"dissolutionDate\":\"2000-01-01T00:00:00+01:00\"," +
                    "\"url\":\"http://www.your-company-site.com\"" +
                "}";

            var json = organization.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
