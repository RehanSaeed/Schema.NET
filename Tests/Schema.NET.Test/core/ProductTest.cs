namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/data-types/products
    public class ProductTest
    {
        private readonly Product product = new Product()
        {
            Name = "Executive Anvil", // Required
            Description = "Sleeker than ACME's Classic Anvil, the Executive Anvil is perfect for the business traveller looking for something to drop from a height.", // Recommended
            Image = new Uri("https://www.example.com/anvil_executive.jpg"), // Required
            Mpn = "925872", // Recommended
            Brand = new Brand() // Recommended
            {
                Name = "ACME",
            },
            AggregateRating = new AggregateRating() // Recommended
            {
                ReviewCount = 89,
                RatingValue = 4.4D,
            },
            Review = new OneOrMany<IReview>((IReview)null), // Recommended
            Offers = new Offer() // Recommended
            {
                Url = (Uri)null, // Recommended
                ItemOffered = (Product)null, // Recommended
                PriceCurrency = "USD", // Required
                Price = 119.99M, // Required
                PriceValidUntil = new DateTime(2020, 11, 5), // Recommended
                ItemCondition = OfferItemCondition.UsedCondition,
                Availability = ItemAvailability.InStock, // Recommended
                Seller = new Organization()
                {
                    Name = "Executive Objects",
                },
            },
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\":\"Product\"," +
            "\"name\":\"Executive Anvil\"," +
            "\"description\":\"Sleeker than ACME's Classic Anvil, the Executive Anvil is perfect for the business traveller looking for something to drop from a height.\"," +
            "\"image\":\"https://www.example.com/anvil_executive.jpg\"," +
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
                "\"availability\":\"https://schema.org/InStock\"," +
                "\"itemCondition\":\"https://schema.org/UsedCondition\"," +
                "\"price\":119.99," +
                "\"priceCurrency\":\"USD\"," +
                "\"priceValidUntil\":\"2020-11-05\"," +
                "\"seller\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"Executive Objects\"" +
                "}" +
            "}" +
        "}";

        [Fact]
        public void ToString_ProductGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.product.ToString());

        [Fact]
        public void Deserializing_ProductJsonLd_ReturnsProduct()
        {
            Assert.Equal(this.product.ToString(), JsonConvert.DeserializeObject<Product>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.product, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Product>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
