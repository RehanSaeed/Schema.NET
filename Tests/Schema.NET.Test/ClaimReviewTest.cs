namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class ClaimReviewTest
    {
        // https://developers.google.com/search/docs/data-types/factcheck
        [Fact]
        public void ToString_ClaimReviewGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var claimReview = new ClaimReview()
            {
                DatePublished = new DateTimeOffset(2016, 6, 22, 0, 0, 0, TimeSpan.Zero), // Required
                Url = new Uri("http://example.com/news/science/worldisflat.html"), // Required
                ItemReviewed = new CreativeWork() // Required
                {
                    Author = new Organization() // Required
                    {
                        Name = "Square World Society", // Required
                        SameAs = new Uri("https://example.flatworlders.com/we-know-that-the-world-is-flat") // Recommended
                    },
                    DatePublished = new DateTimeOffset(2016, 6, 20, 0, 0, 0, TimeSpan.Zero), // Optional
                },
                ClaimReviewed = "The world is flat", // Required
                Author = new Organization() // Required
                {
                    Name = "Example.com science watch"
                },
                ReviewRating = new Rating() // Required
                {
                    RatingValue = 1D, // Required
                    BestRating = 5D, // Required
                    WorstRating = 1D, // Required
                    AlternateName = "False" // Recommended
                }
            };
            var expectedJson =
            "{" +
                "\"@context\":\"http://schema.org\"," +
                "\"@type\":\"ClaimReview\"," +
                "\"url\":\"http://example.com/news/science/worldisflat.html\"," +
                "\"author\":{" +
                    "\"@type\":\"Organization\"," +
                    "\"name\":\"Example.com science watch\"" +
                "}," +
                "\"datePublished\":\"2016-06-22T00:00:00+00:00\"," +
                "\"itemReviewed\":{" +
                    "\"@type\":\"CreativeWork\"," +
                    "\"author\":{" +
                        "\"@type\":\"Organization\"," +
                        "\"name\":\"Square World Society\"," +
                        "\"sameAs\":\"https://example.flatworlders.com/we-know-that-the-world-is-flat\"" +
                    "}," +
                    "\"datePublished\":\"2016-06-20T00:00:00+00:00\"" +
                "}," +
                "\"reviewRating\":{" +
                    "\"@type\":\"Rating\"," +
                    "\"alternateName\":\"False\"," +
                    "\"bestRating\":5.0," +
                    "\"ratingValue\":1.0," +
                    "\"worstRating\":1.0" +
                "}," +
                "\"claimReviewed\":\"The world is flat\"" +
            "}";

            var json = claimReview.ToString();

            Assert.Equal(expectedJson, json);
        }
    }
}
