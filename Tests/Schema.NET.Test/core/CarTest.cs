namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class CarTest
    {
        private readonly Car car = new Car
        {
            Name = "Volvo XC90", // Required
            Description = "The XC90 is pure reflection of luxury that embodies Swedish design heritage. See everything this luxury SUV has to offer.", // Recommended
            Image = new Uri("https://www.example.com/volvo_xc90.jpg"), // Required
            Brand = new Brand // Recommended
            {
                Name = "Volvo",
            },
            Offers = new Offer // Recommended
            {
                Url = (Uri)null, // Recommended
                ItemOffered = (Product)null, // Recommended
                PriceCurrency = "USD", // Required
                Price = 47200M, // Required
                PriceValidUntil = new DateTime(2020, 11, 5), // Recommended
                ItemCondition = OfferItemCondition.NewCondition,
                Availability = ItemAvailability.InStock, // Recommended
                Seller = new Organization
                {
                    Name = "Volvo Dealer",
                },
            },
            ModelDate = 2019,
            VehicleModelDate = 2019,
        };

        private readonly string json =
            "{" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\":\"Car\"," +
                "\"name\":\"Volvo XC90\"," +
                "\"description\":\"The XC90 is pure reflection of luxury that embodies Swedish design heritage. See everything this luxury SUV has to offer.\"," +
                "\"image\":\"https://www.example.com/volvo_xc90.jpg\"," +
                "\"brand\":{" +
                    "\"@type\":\"Brand\"," +
                    "\"name\":\"Volvo\"" +
                "}," +
                "\"offers\":{" +
                    "\"@type\":\"Offer\"," +
                    "\"availability\":\"https://schema.org/InStock\"," +
                    "\"itemCondition\":\"https://schema.org/NewCondition\"," +
                    "\"price\":47200.0," +
                    "\"priceCurrency\":\"USD\"," +
                    "\"priceValidUntil\":\"2020-11-05\"," +
                    "\"seller\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Volvo Dealer\"" +
                    "}" +
                "}," +
                "\"modelDate\":2019," +
                "\"vehicleModelDate\":2019" +
            "}";

        [Fact]
        public void ToString_CarGoogleStructuredData_ReturnsExpectedJsonLd() =>
            Assert.Equal(this.json, this.car.ToString());

        [Fact]
        public void Deserializing_CarJsonLd_ReturnsCar()
        {
            Assert.Equal(this.car.ToString(), JsonConvert.DeserializeObject<Car>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.car, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<Car>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
