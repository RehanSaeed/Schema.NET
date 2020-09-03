namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    public partial interface IReview : ICreativeWork
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        OneOrMany<string> ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="https://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        OneOrMany<IRating> ReviewRating { get; set; }
    }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    [DataContract]
    public partial class Review : CreativeWork, IReview, IEquatable<Review>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Review";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [DataMember(Name = "reviewAspect", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        [DataMember(Name = "reviewBody", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="https://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        [DataMember(Name = "reviewRating", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> ReviewRating { get; set; }

        /// <inheritdoc/>
        public bool Equals(Review other)
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
                this.ReviewAspect == other.ReviewAspect &&
                this.ReviewBody == other.ReviewBody &&
                this.ReviewRating == other.ReviewRating &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Review);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ItemReviewed)
            .And(this.ReviewAspect)
            .And(this.ReviewBody)
            .And(this.ReviewRating)
            .And(base.GetHashCode());
    }
}
