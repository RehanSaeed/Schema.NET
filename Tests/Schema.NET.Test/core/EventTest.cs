namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/events
    public class EventTest
    {
#pragma warning disable CS0649 // Field is never assigned to and will always have its default value.
        private static readonly string NullString;
        private static readonly ItemAvailability? NullItemAvailability;
#pragma warning restore CS0649 // Field is never assigned to and will always have its default value.

        private readonly Event @event = new Event()
        {
            Name = "Jan Lieberman Concert Series: Journey in Jazz", // Required
            Description = "Join us for an afternoon of Jazz with Santa Clara resident and pianist Andy Lagunoff. Complimentary food and beverages will be served.", // Recommended
            StartDate = new DateTimeOffset(2017, 4, 24, 19, 30, 0, TimeSpan.FromHours(-8)), // Required
            Location = new Place() // Required
            {
                Id = null, // Should be ignored
                Name = "Santa Clara City Library, Central Park Library", // Recommended
                Address = new PostalAddress() // Required
                {
                    StreetAddress = "2635 Homestead Rd",
                    AddressLocality = "Santa Clara",
                    PostalCode = "95051",
                    AddressRegion = "CA",
                    AddressCountry = "US",
                },
            },
            Image = new Uri("https://www.example.com/event_image/12345"), // Recommended
            EndDate = new DateTimeOffset(2017, 4, 24, 23, 0, 0, TimeSpan.FromHours(-8)), // Recommended
            Offers = new List<IOffer>() // Recommended
            {
                new Offer
                {
                    Url = new Uri("https://www.example.com/event_offer/12345_201803180430"), // Recommended
                    Price = 30M, // Recommended
                    PriceCurrency = "USD", // Recommended
                    Availability = ItemAvailability.InStock, // Recommended
                    ValidFrom = new DateTimeOffset(2017, 1, 20, 16, 20, 0, TimeSpan.FromHours(-8)), // Recommended
                    Category = NullString,
                },
                new Offer
                {
                    Url = new Uri("https://www.example.com/event_offer/12345_201803180430"), // Recommended
                    Price = 30M, // Recommended
                    PriceCurrency = "USD", // Recommended
                    Availability = NullItemAvailability, // Should be ignored
                    ValidFrom = new DateTimeOffset(2017, 1, 20, 16, 20, 0, TimeSpan.FromHours(-8)), // Recommended
                },
            },
            Performer = new Person() // Recommended
            {
                Name = "Andy Lagunoff", // Recommended
                Telephone = NullString, // Should be ignored
            },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"Event\"," +
            "\"name\":\"Jan Lieberman Concert Series: Journey in Jazz\"," +
            "\"description\":\"Join us for an afternoon of Jazz with Santa Clara resident and pianist Andy Lagunoff. Complimentary food and beverages will be served.\"," +
            "\"image\":\"https://www.example.com/event_image/12345\"," +
            "\"location\":{" +
                "\"@type\":\"Place\"," +
                "\"name\":\"Santa Clara City Library, Central Park Library\"," +
                "\"address\":{" +
                    "\"@type\":\"PostalAddress\"," +
                    "\"addressCountry\":\"US\"," +
                    "\"addressLocality\":\"Santa Clara\"," +
                    "\"addressRegion\":\"CA\"," +
                    "\"postalCode\":\"95051\"," +
                    "\"streetAddress\":\"2635 Homestead Rd\"" +
                "}" +
            "}," +
            "\"offers\":[" +
                "{" +
                    "\"@type\":\"Offer\"," +
                    "\"url\":\"https://www.example.com/event_offer/12345_201803180430\"," +
                    "\"availability\":\"https://schema.org/InStock\"," +
                    "\"price\":30.0," +
                    "\"priceCurrency\":\"USD\"," +
                    "\"validFrom\":\"2017-01-20T16:20:00-08:00\"" +
                "},{" +
                    "\"@type\":\"Offer\"," +
                    "\"url\":\"https://www.example.com/event_offer/12345_201803180430\"," +
                    "\"price\":30.0," +
                    "\"priceCurrency\":\"USD\"," +
                    "\"validFrom\":\"2017-01-20T16:20:00-08:00\"" +
                "}" +
            "]," +
            "\"performer\":{" +
                "\"@type\":\"Person\"," +
                "\"name\":\"Andy Lagunoff\"" +
            "}," +
            "\"startDate\":\"2017-04-24T19:30:00-08:00\"," +
            "\"endDate\":\"2017-04-24T23:00:00-08:00\"" +
        "}";

        [Fact]
        public void ToString_EventGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.@event.ToString());

        [Fact]
        public void Deserializing_EventJsonLd_ReturnsEvent()
        {
            Assert.Equal(this.@event.ToString(), JsonConvert.DeserializeObject<Event>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.@event, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Event>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
