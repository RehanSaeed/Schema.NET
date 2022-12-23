namespace Schema.NET.Test.Examples;

using System;
using Xunit;

// https://developers.google.com/search/docs/data-types/job-postings
public class JobPostingTest
{
    private readonly JobPosting jobPosting = new()
    {
        Title = "Fitter and Turner", // Required
        Description = "<p>Widget assembly role for pressing wheel assemblies.</p><p><strong>Educational Requirements:</strong> Completed level 2 ISTA Machinist Apprenticeship.</p><p><strong>Required Experience:</strong> At least 3 years in a machinist role.</p>", // Required
        Identifier = new PropertyValue() // Recommended
        {
            Name = "MagsRUs Wheel Company",
            Value = "1234567",
        },
        DatePosted = new DateTime(2017, 1, 18), // Required
        ValidThrough = new DateTimeOffset(2017, 3, 18, 0, 0, 0, TimeSpan.Zero), // Required
        EmploymentType = "CONTRACTOR", // Recommended FULL_TIME, PART_TIME, CONTRACTOR, TEMPORARY,INTERN, VOLUNTEER, PER_DIEM, OTHER
        HiringOrganization = new Organization() // Required
        {
            Name = "MagsRUs Wheel Company",
            SameAs = new Uri("https://www.magsruswheelcompany.com"),
        },
        JobLocation = new Place() // Required
        {
            Address = new PostalAddress()
            {
                AddressCountry = "US",
                AddressLocality = "Detroit",
                AddressRegion = "MI",
                PostalCode = "48201",
                StreetAddress = "555 Clancy St",
            },
        },
        BaseSalary = new MonetaryAmount() // Recommended
        {
            Currency = "USD",
            Value = new QuantitativeValue()
            {
                Value = 40D,
                UnitText = "HOUR", // HOUR, WEEK, MONTH, YEAR
            },
        },
    };

    private readonly string json = /*lang=json,strict*/
        """
        {
            "@context": "https://schema.org",
            "@type": "JobPosting",
            "title": "Fitter and Turner",
            "description": "<p>Widget assembly role for pressing wheel assemblies.</p><p><strong>Educational Requirements:</strong> Completed level 2 ISTA Machinist Apprenticeship.</p><p><strong>Required Experience:</strong> At least 3 years in a machinist role.</p>",
            "identifier": {
                "@type": "PropertyValue",
                "name": "MagsRUs Wheel Company",
                "value": "1234567"
            },
            "baseSalary": {
                "@type": "MonetaryAmount",
                "currency": "USD",
                "value": {
                    "@type": "QuantitativeValue",
                    "unitText": "HOUR",
                    "value": 40
                }
            },
            "datePosted": "2017-01-18",
            "employmentType": "CONTRACTOR",
            "hiringOrganization": {
                "@type": "Organization",
                "name": "MagsRUs Wheel Company",
                "sameAs": "https://www.magsruswheelcompany.com"
            },
            "jobLocation": {
                "@type": "Place",
                "address": {
                    "@type": "PostalAddress",
                    "addressCountry": "US",
                    "addressLocality": "Detroit",
                    "addressRegion": "MI",
                    "postalCode": "48201",
                    "streetAddress": "555 Clancy St"
                }
            },
            "validThrough":"2017-03-18T00:00:00+00:00"
        }
        """;

    [Fact]
    public void ToString_JobPostingGoogleStructuredData_ReturnsExpectedJsonLd() =>
        Assert.Equal(this.json.MinifyJson(), this.jobPosting.ToString());

    [Fact]
    public void Deserializing_JobPostingJsonLd_ReturnsJobPosting()
    {
        Assert.Equal(this.jobPosting.ToString(), SchemaSerializer.DeserializeObject<JobPosting>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.jobPosting), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<JobPosting>(this.json)!));
    }
}
