namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class RestaurantTest
    {
        [Fact]
        public void ToString_RestaurantGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var restaurant = new Restaurant()
            {
                Id = new Uri("http://davessteakhouse.example.com"),
                Name = "Dave's Steak House",
                Image = new Uri("http://davessteakhouse.example.com/logo.jpg"),
                SameAs = new Uri("http://davessteakhouse.example.com"),
                ServesCuisine = "Steak House",
                PriceRange = "$$$",
                Address = new PostalAddress()
                {
                    AddressCountry = "US",
                    AddressLocality = "New York",
                    AddressRegion = "NY",
                    PostalCode = "10019",
                    StreetAddress = "148 W 51st St"
                },
                Telephone = "+12122459600",
                Geo = new GeoCoordinates()
                {
                    Latitude = 40.761293D,
                    Longitude = -73.982294
                },
                AggregateRating = new AggregateRating()
                {
                    RatingValue = 88D,
                    BestRating = 100D,
                    WorstRating = 1D,
                    RatingCount = 20
                },
                Review = new Review()
                {
                    Description = "Great old fashioned steaks but the salads are sub par.",
                    Url = new Uri("http://www.localreviews.com/restaurants/1/2/3/daves-steak-house.html"),
                    Author = new Person()
                    {
                        Name = "Lisa Kennedy",
                        SameAs = new Uri("https://plus.google.com/114108465800532712602")
                    },
                    Publisher = new Organization()
                    {
                        Name = "Denver Post",
                        SameAs = new Uri("http://www.denverpost.com")
                    },
                    DatePublished = new DateTimeOffset(2014, 3, 13, 20, 0, 0, TimeSpan.Zero),
                    InLanguage = "en",
                    ReviewRating = new Rating()
                    {
                        WorstRating = 1D,
                        BestRating = 4D,
                        RatingValue = 3.5
                    }
                }
            };
            var expectedJson =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"Restaurant\"," +
                "\"@id\":\"http://davessteakhouse.example.com\"," +
                "\"name\":\"Dave's Steak House\"," +
                "\"image\":\"http://davessteakhouse.example.com/logo.jpg\"," +
                "\"sameAs\":\"http://davessteakhouse.example.com\"," +
                "\"address\":{" +
                    "\"@type\":\"PostalAddress\"," +
                    "\"addressCountry\":\"US\"," +
                    "\"addressLocality\":\"New York\"," +
                    "\"addressRegion\":\"NY\"," +
                    "\"postalCode\":\"10019\"," +
                    "\"streetAddress\":\"148 W 51st St\"" +
                "}," +
                "\"aggregateRating\":{" +
                    "\"@type\":\"AggregateRating\"," +
                    "\"bestRating\":100.0," +
                    "\"ratingValue\":88.0," +
                    "\"worstRating\":1.0," +
                    "\"ratingCount\":20" +
                "}," +
                "\"geo\":{" +
                    "\"@type\":\"GeoCoordinates\"," +
                    "\"latitude\":40.761293," +
                    "\"longitude\":-73.982294" +
                "}," +
                "\"review\":{" +
                    "\"@type\":\"Review\"," +
                    "\"description\":\"Great old fashioned steaks but the salads are sub par.\"," +
                    "\"url\":\"http://www.localreviews.com/restaurants/1/2/3/daves-steak-house.html\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"Lisa Kennedy\"," +
                        "\"sameAs\":\"https://plus.google.com/114108465800532712602\"" +
                    "}," +
                    "\"datePublished\":\"2014-03-13T20:00:00+00:00\"," +
                    "\"inLanguage\":\"en\"," +
                    "\"publisher\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Denver Post\"," +
                        "\"sameAs\":\"http://www.denverpost.com\"" +
                    "}," +
                    "\"reviewRating\":{" +
                        "\"@type\":\"Rating\"," +
                        "\"bestRating\":4.0," +
                        "\"ratingValue\":3.5," +
                        "\"worstRating\":1.0" +
                    "}" +
                "}," +
                "\"telephone\":\"+12122459600\"," +
                "\"priceRange\":\"$$$\"," +
                "\"servesCuisine\":\"Steak House\"" +
            "}";

            var json = restaurant.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
