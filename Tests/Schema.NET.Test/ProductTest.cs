namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class ProductTest
    {
        // https://developers.google.com/search/docs/data-types/products
        [Fact]
        public void ToString_ProductGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var product = new Product()
            {
                Name = "Executive Anvil", // Required
                Description = "Sleeker than ACME's Classic Anvil, the Executive Anvil is perfect for the business traveller looking for something to drop from a height.", // Recommended
                Image = new Uri("http://www.example.com/anvil_executive.jpg"), // Required
                Mpn = "925872", // Recommended
                Brand = new Brand() // Recommended
                {
                    Name = "ACME"
                },
                AggregateRating = new AggregateRating() // Recommended
                {
                    ReviewCount = 89,
                    RatingValue = 4.4D
                },
                Review = null, // Recommended
                Offers = new Offer() // Recommended
                {
                    Url = null, // Recommended
                    ItemOffered = null, // Recommended
                    PriceCurrency = "USD", // Required
                    Price = 119.99M, // Required
                    PriceValidUntil = new DateTimeOffset(2020, 11, 5, 0, 0, 0, TimeSpan.Zero), // Recommended
                    ItemCondition = OfferItemCondition.UsedCondition,
                    Availability = ItemAvailability.InStock, // Recommended
                    Seller = new Organization()
                    {
                        Name = "Executive Objects"
                    }
                }
            };
            var expectedJson =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"Product\"," +
                "\"name\":\"Executive Anvil\"," +
                "\"description\":\"Sleeker than ACME's Classic Anvil, the Executive Anvil is perfect for the business traveller looking for something to drop from a height.\"," +
                "\"image\":\"http://www.example.com/anvil_executive.jpg\"," +
                "\"aggregateRating\":{" +
                    "\"@type\":\"AggregateRating\"," +
                    "\"ratingValue\":4.4," +
                    "\"reviewCount\":89" +
                "}," +
                "\"brand\":{" +
                    "\"@type\":\"Brand\"," +
                    "\"name\":\"ACME\"" +
                "}," +
                "\"mpn\":\"925872\"," +
                "\"offers\":{" +
                    "\"@type\":\"Offer\"," +
                    "\"availability\":\"http://schema.org/InStock\"," +
                    "\"itemCondition\":\"http://schema.org/UsedCondition\"," +
                    "\"price\":119.99," +
                    "\"priceCurrency\":\"USD\"," +
                    "\"priceValidUntil\":\"2020-11-05T00:00:00+00:00\"," +
                    "\"seller\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Executive Objects\"" +
                    "}" +
                "}" +
            "}";

            var json = product.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
