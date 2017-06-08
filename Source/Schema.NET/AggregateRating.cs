namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    [DataContract]
    public class AggregateRating : Rating
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AggregateRating";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [DataMember(Name = "reviewCount")]
        public int ReviewCount { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [DataMember(Name = "ratingCount")]
        public int RatingCount { get; set; }
    }
}
