namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/courses
    public class CourseTest
    {
        private readonly Course course = new Course()
        {
            Name = "Introduction to Computer Science and Programming", // Required
            Description = "Introductory CS course laying out the basics.", // Required
            Provider = new Organization() // Recommended
            {
                Name = "University of Technology - Eureka",
                SameAs = new Uri("https://www.ut-eureka.edu"),
            },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"Course\"," +
            "\"name\":\"Introduction to Computer Science and Programming\"," +
            "\"description\":\"Introductory CS course laying out the basics.\"," +
            "\"provider\":{" +
                "\"@type\":\"Organization\"," +
                "\"name\":\"University of Technology - Eureka\"," +
                "\"sameAs\":\"https://www.ut-eureka.edu\"" +
            "}" +
        "}";

        [Fact]
        public void ToString_CourseGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.course.ToString());

        [Fact]
        public void Deserializing_CourseJsonLd_ReturnsCourse()
        {
            Assert.Equal(this.course.ToString(), JsonConvert.DeserializeObject<Course>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.course, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Course>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
