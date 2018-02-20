namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    [DataContract]
    public partial class AggregateRating : Rating
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateRating";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [DataMember(Name = "ratingCount", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [DataMember(Name = "reviewCount", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? ReviewCount { get; set; }
    }
}
