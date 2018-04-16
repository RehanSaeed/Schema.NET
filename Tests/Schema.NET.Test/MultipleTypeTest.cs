namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class MultipleTypeTest
    {
        private readonly Course course = new Course()
        {
            Name = "Introduction to Computer Science and Programming", // Required
            Description = "Introductory CS course laying out the basics.", // Required
            Provider = new Organization() // Recommended
            {
                Name = "University of Technology - Eureka",
                SameAs = new Uri("http://www.ut-eureka.edu")
            }
        };

        private readonly string json =
            "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"Course\"," +
            "\"name\":\"Introduction to Computer Science and Programming\"," +
            "\"description\":\"Introductory CS course laying out the basics.\"," +
            "\"provider\":{" +
            "\"@type\":[\"Organization\"]," + // Note the array that defines the type(s)
            "\"name\":\"University of Technology - Eureka\"," +
            "\"sameAs\":\"http://www.ut-eureka.edu\"" +
            "}" +
            "}";

        [Fact]
        public void Should_deserialize_to_the_first_type()
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                DateParseHandling = DateParseHandling.DateTimeOffset
            };

            Assert.Equal(this.course.ToString(), JsonConvert.DeserializeObject<Course>(this.json, serializerSettings).ToString());
        }
    }
}