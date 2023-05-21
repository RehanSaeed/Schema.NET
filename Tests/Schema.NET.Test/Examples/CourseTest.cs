namespace Schema.NET.Test.Examples;

using System;
using Xunit;

// https://developers.google.com/search/docs/data-types/courses
public class CourseTest
{
    private readonly Course course = new()
    {
        Name = "Introduction to Computer Science and Programming", // Required
        Description = "Introductory CS course laying out the basics.", // Required
        SourceOrganization = new Organization() // Note: This is typically set via "Provider" (a pending property) and is required
        {
            Name = "University of Technology - Eureka",
            SameAs = new Uri("https://www.ut-eureka.edu"),
        },
    };

    private readonly string json = /*lang=json,strict*/
        """
        {
            "@context": "https://schema.org",
            "@type": "Course",
            "name": "Introduction to Computer Science and Programming",
            "description": "Introductory CS course laying out the basics.",
            "sourceOrganization": {
                "@type": "Organization",
                "name": "University of Technology - Eureka",
                "sameAs": "https://www.ut-eureka.edu"
            }
        }
        """;

    [Fact]
    public void ToString_CourseGoogleStructuredData_ReturnsExpectedJsonLd() =>
        Assert.Equal(this.json.MinifyJson(), this.course.ToString());

    [Fact]
    public void Deserializing_CourseJsonLd_ReturnsCourse()
    {
        Assert.Equal(this.course.ToString(), SchemaSerializer.DeserializeObject<Course>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.course), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<Course>(this.json)!));
    }
}
