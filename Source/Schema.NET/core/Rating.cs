namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    [DataContract]
    public partial class Rating : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Rating";

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Author { get; set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [DataMember(Name = "bestRating", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, string>? BestRating { get; set; }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [DataMember(Name = "ratingValue", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, string>? RatingValue { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [DataMember(Name = "reviewAspect", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ReviewAspect { get; set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [DataMember(Name = "worstRating", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, string>? WorstRating { get; set; }
    }
}
