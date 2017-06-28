namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class EventTest
    {
        // https://developers.google.com/search/docs/data-types/events
        [Fact]
        public void ToString_EventGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var @event = new Event()
            {
                Name = "Jan Lieberman Concert Series: Journey in Jazz",
                Description = "Join us for an afternoon of Jazz with Santa Clara resident and pianist Andy Lagunoff. Complimentary food and beverages will be served.",
                StartDate = new DateTimeOffset(2017, 4, 24, 19, 30, 0, TimeSpan.FromHours(-8)),
                Location = new Place()
                {
                    Name = "Santa Clara City Library, Central Park Library",
                    Address = new PostalAddress()
                    {
                        StreetAddress = "2635 Homestead Rd",
                        AddressLocality = "Santa Clara",
                        PostalCode = "95051",
                        AddressRegion = "CA",
                        AddressCountry = "US"
                    }
                },
                Image = new Uri("http://www.example.com/event_image/12345"),
                EndDate = new DateTimeOffset(2017, 4, 24, 23, 0, 0, TimeSpan.FromHours(-8)),
                Offers = new Offer()
                {
                    Url = new Uri("https://www.example.com/event_offer/12345_201803180430"),
                    Price = 30M,
                    PriceCurrency = "USD",
                    Availability = ItemAvailability.InStock,
                    ValidFrom = new DateTimeOffset(2017, 1, 20, 16, 20, 0, TimeSpan.FromHours(-8))
                },
                Performer = new Person()
                {
                    Name = "Andy Lagunoff"
                }
            };
            var expectedJson =
                "{" +
                    "\"@context\":\"http://schema.org\"," +
                    "\"@type\":\"Event\"," +
                    "\"name\":\"Jan Lieberman Concert Series: Journey in Jazz\"," +
                    "\"description\":\"Join us for an afternoon of Jazz with Santa Clara resident and pianist Andy Lagunoff. Complimentary food and beverages will be served.\"," +
                    "\"image\":\"http://www.example.com/event_image/12345\"," +
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
                    "\"offers\":{" +
                        "\"@type\":\"Offer\"," +
                        "\"url\":\"https://www.example.com/event_offer/12345_201803180430\"," +
                        "\"availability\":\"http://schema.org/InStock\"," +
                        "\"price\":30.0," +
                        "\"priceCurrency\":\"USD\"," +
                        "\"validFrom\":\"2017-01-20T16:20:00-08:00\"" +
                    "}," +
                    "\"performer\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"Andy Lagunoff\"" +
                    "}," +
                    "\"startDate\":\"2017-04-24T19:30:00-08:00\"," +
                    "\"endDate\":\"2017-04-24T23:00:00-08:00\"" +
                "}";

            var json = @event.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
