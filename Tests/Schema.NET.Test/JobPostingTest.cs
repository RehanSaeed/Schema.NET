namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class JobPostingTest
    {
        [Fact]
        public void ToString_JobPostingGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var jobPosting = new JobPosting()
            {
                Title = "Fitter and Turner",
                Description = "<p>Widget assembly role for pressing wheel assemblies.</p><p><strong>Educational Requirements:</strong> Completed level 2 ISTA Machinist Apprenticeship.</p><p><strong>Required Experience:</strong> At least 3 years in a machinist role.</p>",
                Identifier = new PropertyValue()
                {
                    Name = "MagsRUs Wheel Company",
                    Value = "1234567"
                },
                DatePosted = new DateTimeOffset(2017, 1, 18, 0, 0, 0, TimeSpan.Zero),
                ValidThrough = new DateTimeOffset(2017, 3, 18, 0, 0, 0, TimeSpan.Zero),
                EmploymentType = "CONTRACTOR",
                HiringOrganization = new Organization()
                {
                    Name = "MagsRUs Wheel Company",
                    SameAs = new Uri("http://www.magsruswheelcompany.com")
                },
                JobLocation = new Place()
                {
                    Address = new PostalAddress()
                    {
                        AddressCountry = "US",
                        AddressLocality = "Detroit",
                        AddressRegion = "MI",
                        PostalCode = "48201",
                        StreetAddress = "555 Clancy St"
                    }
                },
                BaseSalary = new MonetaryAmount()
                {
                    Currency = "USD",
                    Value = new QuantitativeValue()
                    {
                        Value = 40D,
                        UnitText = "HOUR"
                    }
                }
            };
            var expectedJson =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"JobPosting\"," +
                "\"title\":\"Fitter and Turner\"," +
                "\"description\":\"<p>Widget assembly role for pressing wheel assemblies.</p><p><strong>Educational Requirements:</strong> Completed level 2 ISTA Machinist Apprenticeship.</p><p><strong>Required Experience:</strong> At least 3 years in a machinist role.</p>\"," +
                "\"identifier\":{" +
                    "\"@type\":\"PropertyValue\"," +
                    "\"name\":\"MagsRUs Wheel Company\"," +
                    "\"value\":\"1234567\"" +
                "}," +
                "\"baseSalary\":{" +
                    "\"@type\":\"MonetaryAmount\"," +
                    "\"currency\":\"USD\"," +
                    "\"value\":{" +
                        "\"@type\":\"QuantitativeValue\"," +
                        "\"unitText\":\"HOUR\"," +
                        "\"value\":40.0" +
                    "}" +
                "}," +
                "\"datePosted\":\"2017-01-18T00:00:00+00:00\"," +
                "\"employmentType\":\"CONTRACTOR\"," +
                "\"hiringOrganization\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"MagsRUs Wheel Company\"," +
                    "\"sameAs\":\"http://www.magsruswheelcompany.com\"" +
                "}," +
                "\"jobLocation\":{" +
                    "\"@type\":\"Place\"," +
                    "\"address\":{" +
                        "\"@type\":\"PostalAddress\"," +
                        "\"addressCountry\":\"US\"," +
                        "\"addressLocality\":\"Detroit\"," +
                        "\"addressRegion\":\"MI\"," +
                        "\"postalCode\":\"48201\"," +
                        "\"streetAddress\":\"555 Clancy St\"" +
                    "}" +
                "}," +
                "\"validThrough\":\"2017-03-18T00:00:00+00:00\"" +
            "}";

            var json = jobPosting.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
