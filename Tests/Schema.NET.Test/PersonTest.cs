namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/social-profile-links
    public class PersonTest
    {
        private readonly Person person = new Person()
        {
            Name = "Name", // Required
            SameAs = new List<Uri>() // Required
            {
                new Uri("http://www.facebook.com/your-profile"),
                new Uri("http://instagram.com/yourProfile"),
                new Uri("http://www.linkedin.com/in/yourprofile"),
                new Uri("http://plus.google.com/your_profile")
            },
            Url = new Uri("https://example.com") // Required
        };

        private readonly string json =
        "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"Person\"," +
            "\"name\":\"Name\"," +
            "\"sameAs\":[" +
                "\"http://www.facebook.com/your-profile\"," +
                "\"http://instagram.com/yourProfile\"," +
                "\"http://www.linkedin.com/in/yourprofile\"," +
                "\"http://plus.google.com/your_profile\"" +
            "]," +
            "\"url\":\"https://example.com\"" +
        "}";

        [Fact]
        public void ToString_SiteNameGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            Assert.Equal(this.json, this.person.ToString());
        }

        [Fact]
        public void Deserializing_PersonJsonLd_ReturnsPerson()
        {
            Assert.Equal(this.person.ToString(), JsonConvert.DeserializeObject<Person>(this.json).ToString());
        }
    }
}
