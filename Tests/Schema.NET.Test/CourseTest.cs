namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class CourseTest
    {
        [Fact]
        public void ToString_CourseGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var course = new Course()
            {
                Name = "Introduction to Computer Science and Programming",
                Description = "Introductory CS course laying out the basics.",
                Provider = new Organization()
                {
                    Name = "University of Technology - Eureka",
                    SameAs = new Uri("http://www.ut-eureka.edu")
                }
            };
            var expectedJson = "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"Course\"," +
                "\"name\":\"Introduction to Computer Science and Programming\"," +
                "\"description\":\"Introductory CS course laying out the basics.\"," +
                "\"provider\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"University of Technology - Eureka\"," +
                    "\"sameAs\":\"http://www.ut-eureka.edu\"" +
                "}" +
            "}";

            var json = course.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
