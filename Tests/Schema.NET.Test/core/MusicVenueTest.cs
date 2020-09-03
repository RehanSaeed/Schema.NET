namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class MusicVenueTest
    {
        private readonly MusicVenue musicVenue = new MusicVenue()
        {
            Name = "Dolby Theatre", // Required
            Description = "Host to a range of prestigious events including movie premieres, concerts & the Oscars https://www.dolbytheatre.com", // Recommended
            Identifier = "KovZpZAdtaEA", // Recommended
            Image = new ImageObject() // Recommended
            {
                ContentUrl = new Uri("https://s1.ticketm.net/dam/v/e6b/380fa861-3f46-44a9-a514-21553f7fbe6b_379601_SOURCE.jpg"), // Required
            },
            SameAs = new List<Uri>
            {
                new Uri("https://www.twitter.com/dolbytheatre"), // Recommended
                new Uri("https://www.dolbytheatre.com"), // Recommended
            },
            Url = new Uri("https://foursquare.com/dolbytheatre"), // Recommended
            Address = new PostalAddress() // Recommended
            {
                StreetAddress = "6801 Hollywood Blvd", // Recommended
                AddressLocality = "Los Angeles", // Recommended
                AddressRegion = "CA", // Recommended
                PostalCode = "90028", // Recommended
                AddressCountry = "US", // Recommended
            },
            Geo = new GeoCoordinates() // Recommended
            {
                Latitude = "34.1018929033898", // Recommended
                Longitude = "-118.340147939959", // Recommended
            },
            Telephone = "(323) 308-6300", // Recommended
        };

        private readonly string json =
        "{" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"MusicVenue\"," +
            "\"name\": \"Dolby Theatre\"," +
            "\"description\": \"Host to a range of prestigious events including movie premieres, concerts & the Oscars https://www.dolbytheatre.com\"," +
            "\"identifier\": \"KovZpZAdtaEA\"," +
            "\"image\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"ImageObject\"," +
                "\"contentUrl\": \"https://s1.ticketm.net/dam/v/e6b/380fa861-3f46-44a9-a514-21553f7fbe6b_379601_SOURCE.jpg\"" +
            "}," +
            "\"sameAs\": [" +
                "\"https://www.twitter.com/dolbytheatre\"," +
                "\"https://www.dolbytheatre.com\"" +
            "]," +
            "\"url\": \"https://foursquare.com/dolbytheatre\"," +
            "\"address\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"PostalAddress\"," +
                "\"addressCountry\": \"US\"," +
                "\"addressLocality\": \"Los Angeles\"," +
                "\"addressRegion\": \"CA\"," +
                "\"postalCode\": \"90028\"," +
                "\"streetAddress\": \"6801 Hollywood Blvd\"" +
            "}," +
            "\"geo\": {" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\": \"GeoCoordinates\"," +
                "\"latitude\": \"34.1018929033898\"," +
                "\"longitude\": \"-118.340147939959\"" +
            "}," +
            "\"telephone\": \"(323) 308-6300\"" +
        "}";

        [Fact]
        public void Deserializing_MusicVenueJsonLd_ReturnsMusicVenue()
        {
            Assert.Equal(this.musicVenue.ToString(), JsonConvert.DeserializeObject<MusicVenue>(this.json, TestDefaults.DefaultJsonSerializerSettings).ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.musicVenue, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<MusicVenue>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
