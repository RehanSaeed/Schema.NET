namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    public partial interface IAggregateRating : IRating
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        OneOrMany<int?> RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        OneOrMany<int?> ReviewCount { get; set; }
    }

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    [DataContract]
    public partial class AggregateRating : Rating, IAggregateRating, IEquatable<AggregateRating>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [DataMember(Name = "ratingCount", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [DataMember(Name = "reviewCount", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ReviewCount { get; set; }

        /// <inheritdoc/>
        public bool Equals(AggregateRating other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.ItemReviewed == other.ItemReviewed &&
                this.RatingCount == other.RatingCount &&
                this.ReviewCount == other.ReviewCount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AggregateRating);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ItemReviewed)
            .And(this.RatingCount)
            .And(this.ReviewCount)
            .And(base.GetHashCode());
    }
}
