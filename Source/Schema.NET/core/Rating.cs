namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    public partial interface IRating : IIntangible
    {
        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        Values<IOrganization, IPerson> Author { get; set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        Values<double?, string> BestRating { get; set; }

        /// <summary>
        /// A short explanation (e.g. one to two sentences) providing background context and other information that led to the conclusion expressed in the rating. This is particularly applicable to ratings associated with "fact check" markup using &lt;a class="localLink" href="https://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> RatingExplanation { get; set; }

        /// <summary>
        /// The rating for the content.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<double?, string> RatingValue { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        Values<double?, string> WorstRating { get; set; }
    }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    [DataContract]
    public partial class Rating : Intangible, IRating, IEquatable<Rating>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Author { get; set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [DataMember(Name = "bestRating", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> BestRating { get; set; }

        /// <summary>
        /// A short explanation (e.g. one to two sentences) providing background context and other information that led to the conclusion expressed in the rating. This is particularly applicable to ratings associated with "fact check" markup using &lt;a class="localLink" href="https://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ratingExplanation", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RatingExplanation { get; set; }

        /// <summary>
        /// The rating for the content.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "ratingValue", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> RatingValue { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [DataMember(Name = "reviewAspect", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [DataMember(Name = "worstRating", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> WorstRating { get; set; }

        /// <inheritdoc/>
        public bool Equals(Rating other)
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
                this.Author == other.Author &&
                this.BestRating == other.BestRating &&
                this.RatingExplanation == other.RatingExplanation &&
                this.RatingValue == other.RatingValue &&
                this.ReviewAspect == other.ReviewAspect &&
                this.WorstRating == other.WorstRating &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Rating);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Author)
            .And(this.BestRating)
            .And(this.RatingExplanation)
            .And(this.RatingValue)
            .And(this.ReviewAspect)
            .And(this.WorstRating)
            .And(base.GetHashCode());
    }
}
