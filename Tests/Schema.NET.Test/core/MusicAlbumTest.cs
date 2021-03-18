namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    public class MusicAlbumTest
    {
        private readonly MusicAlbum musicAlbum = new()
        {
            Name = "Hail to the Thief", // Required
            Identifier = "1oW3v5Har9mvXnGk0x4fHm", // Recommended
            Image = new List<IImageObject> // Recommended
            {
                new ImageObject() // Recommended
                {
                    ContentUrl = new Uri("https://i.scdn.co/image/5ded47fd3d05325dd0faaf4619481e1f25a21ec7"), // Required
                },
                new ImageObject() // Recommended
                {
                    ContentUrl = new Uri("https://is4-ssl.mzstatic.com/image/thumb/Music69/v4/cc/1c/90/cc1c9039-c3ba-4256-e251-1687df46cb0a/cover.jpg/1400x1400bb.jpeg"), // Required
                },
            },
            SameAs = new Uri("https://music.apple.com/us/album/hail-to-the-thief/1097863576"), // Recommended
            Url = new Uri("https://open.spotify.com/album/1oW3v5Har9mvXnGk0x4fHm"), // Recommended
            AggregateRating = new AggregateRating() // Recommended
            {
                BestRating = 100, // Required
                RatingValue = 60, // Required
                WorstRating = 0, // Required
            },
            DatePublished = new DateTime(2003, 5, 26), // Recommended
            Offers = new Offer() // Recommended
            {
                Gtin12 = "634904078560",
            },
            NumTracks = 14, // Recommended
            AlbumRelease = new MusicRelease() // Recommended
            {
                RecordLabel = new Organization()
                {
                    Name = "XL Recordings", // Required
                },
            },
            ByArtist = new MusicGroup() // Recommended
            {
                Name = "Radiohead", // Required
                Identifier = "4Z8W4fKeB5YxbusRsdQVPb", // Recommended
            },
        };

        private readonly string json =
        "{" +
            "\"@context\": \"https://schema.org\"," +
            "\"@type\": \"MusicAlbum\"," +
            "\"name\": \"Hail to the Thief\"," +
            "\"identifier\": \"1oW3v5Har9mvXnGk0x4fHm\"," +
            "\"image\": [{" +
                    "\"$type\": \"Schema.NET.ImageObject, Schema.NET\"," +
                    "\"@context\": \"https://schema.org\"," +
                    "\"@type\": \"ImageObject\"," +
                    "\"contentUrl\": \"https://i.scdn.co/image/5ded47fd3d05325dd0faaf4619481e1f25a21ec7\"" +
                "}, {" +
                    "\"$type\": \"Schema.NET.ImageObject, Schema.NET\"," +
                    "\"@context\": \"https://schema.org\"," +
                    "\"@type\": \"ImageObject\"," +
                    "\"contentUrl\": \"https://is4-ssl.mzstatic.com/image/thumb/Music69/v4/cc/1c/90/cc1c9039-c3ba-4256-e251-1687df46cb0a/cover.jpg/1400x1400bb.jpeg\"" +
                "}" +
            "]," +
            "\"sameAs\": \"https://music.apple.com/us/album/hail-to-the-thief/1097863576\"," +
            "\"url\": \"https://open.spotify.com/album/1oW3v5Har9mvXnGk0x4fHm\"," +
            "\"aggregateRating\": {" +
                "\"@context\": \"https://schema.org\"," +
                "\"@type\": \"AggregateRating\"," +
                "\"bestRating\": 100," +
                "\"ratingValue\": 60," +
                "\"worstRating\": 0" +
            "}," +
            "\"datePublished\": \"2003-05-26\"," +
            "\"offers\": {" +
                "\"@context\": \"https://schema.org\"," +
                "\"@type\": \"Offer\"," +
                "\"gtin12\": \"634904078560\"" +
            "}," +
            "\"numTracks\": 14," +
            "\"albumRelease\": {" +
                "\"@context\": \"https://schema.org\"," +
                "\"@type\": \"MusicRelease\"," +
                "\"recordLabel\": {" +
                    "\"@context\": \"https://schema.org\"," +
                    "\"@type\": \"Organization\"," +
                    "\"name\": \"XL Recordings\"" +
                "}" +
            "}," +
            "\"byArtist\": {" +
                "\"@context\": \"https://schema.org\"," +
                "\"@type\": \"MusicGroup\"," +
                "\"name\": \"Radiohead\"," +
                "\"identifier\": \"4Z8W4fKeB5YxbusRsdQVPb\"" +
            "}" +
        "}";

        [Fact]
        public void Deserializing_MusicAlbumJsonLd_ReturnsMusicAlbum()
        {
            Assert.Equal(this.musicAlbum.ToString(), JsonConvert.DeserializeObject<MusicAlbum>(this.json, TestDefaults.DefaultJsonSerializerSettings)!.ToString());
            Assert.Equal(JsonConvert.SerializeObject(this.musicAlbum, TestDefaults.DefaultJsonSerializerSettings), JsonConvert.SerializeObject(JsonConvert.DeserializeObject<MusicAlbum>(this.json, TestDefaults.DefaultJsonSerializerSettings), TestDefaults.DefaultJsonSerializerSettings));
        }
    }
}
