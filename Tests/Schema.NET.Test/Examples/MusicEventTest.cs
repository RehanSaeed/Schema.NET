namespace Schema.NET.Test.Examples;

using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

public class MusicEventTest
{
    private readonly MusicEvent musicEvent = new()
    {
        Name = "Arash & Tohi", // Required
        Identifier = "vv1AaZAQ8Gkds-P77",
        Url = new Uri("https://www.ticketmaster.com/arash-tohi-hollywood-california-06-22-2019/event/09005690F1865104"), // Recommended
        Location = new MusicVenue() // Recommended
        {
            Name = "Dolby Theatre", // Required
            Identifier = "KovZpZAdtaEA", // Recommended
        },
        Offers = new Offer() // Recommended
        {
            Url = new Uri("https://www.ticketmaster.com/arash-tohi-hollywood-california-06-22-2019/event/09005690F1865104"), // Recommended
            AvailabilityStarts = DateTimeOffset.Parse("2019-04-24T21:00:00-07:00", CultureInfo.InvariantCulture), // Recommended
            AvailabilityEnds = DateTimeOffset.Parse("2019-06-23T01:00:00-07:00", CultureInfo.InvariantCulture), // Recommended
            PriceSpecification = new PriceSpecification() // Recommended
            {
                MinPrice = 80, // Recommended
                MaxPrice = 295, // Recommended
                PriceCurrency = "USD", // Recommended
            },
        },
        Performer = new List<IOrganization>() // Recommended
            {
                new MusicGroup() // Recommended
                {
                    Name = "Arash", // Required
                    Identifier = "K8vZ917ukD7", // Recommended
                },
                new MusicGroup() // Recommended
                {
                    Name = "Tohi", // Required
                    Identifier = "K8vZ917bA70", // Recommended
                },
            },
        StartDate = DateTimeOffset.Parse("2019-06-23T03:00:00-07:00", CultureInfo.InvariantCulture), // Recommended
    };

    private readonly string json =
    "{" +
        "\"@context\":\"https://schema.org\"," +
        "\"@type\": \"MusicEvent\"," +
        "\"name\": \"Arash & Tohi\"," +
        "\"identifier\": \"vv1AaZAQ8Gkds-P77\"," +
        "\"url\": \"https://www.ticketmaster.com/arash-tohi-hollywood-california-06-22-2019/event/09005690F1865104\"," +
        "\"location\": {" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"MusicVenue\"," +
            "\"name\": \"Dolby Theatre\"," +
            "\"identifier\": \"KovZpZAdtaEA\"" +
        "}," +
        "\"offers\": {" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"Offer\"," +
            "\"url\": \"https://www.ticketmaster.com/arash-tohi-hollywood-california-06-22-2019/event/09005690F1865104\"," +
            "\"availabilityEnds\": \"2019-06-23T01:00:00-07:00\"," +
            "\"availabilityStarts\": \"2019-04-24T21:00:00-07:00\"," +
            "\"priceSpecification\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"PriceSpecification\"," +
                "\"maxPrice\": 295," +
                "\"minPrice\": 80," +
                "\"priceCurrency\": \"USD\"" +
            "}" +
        "}," +
        "\"performer\": [" +
            "{" +
                "\"$type\": \"Schema.NET.MusicGroup, Schema.NET\"," +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"MusicGroup\"," +
                "\"name\": \"Arash\"," +
                "\"identifier\": \"K8vZ917ukD7\"" +
            "}," +
            "{" +
                "\"$type\": \"Schema.NET.MusicGroup, Schema.NET\"," +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"MusicGroup\"," +
                "\"name\": \"Tohi\"," +
                "\"identifier\": \"K8vZ917bA70\"" +
            "}" +
        "]," +
        "\"startDate\": \"2019-06-23T03:00:00-07:00\"" +
    "}";

    [Fact]
    public void Deserializing_MusicEventJsonLd_ReturnsMusicEvent()
    {
        Assert.Equal(this.musicEvent.ToString(), SchemaSerializer.DeserializeObject<MusicEvent>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.musicEvent), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<MusicEvent>(this.json)!));
    }
}
