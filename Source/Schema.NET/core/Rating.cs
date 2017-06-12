namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

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
        [DataMember(Name = "author", Order = 2)]
        public object Author { get; protected set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [IgnoreDataMember]
        public Organization AuthorOrganization
        {
            get => this.Author as Organization;
            set => this.Author = value;
        }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [IgnoreDataMember]
        public Person AuthorPerson
        {
            get => this.Author as Person;
            set => this.Author = value;
        }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [DataMember(Name = "bestRating", Order = 3)]
        public object BestRating { get; protected set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [IgnoreDataMember]
        public double? BestRatingNumber
        {
            get => this.BestRating as double?;
            set => this.BestRating = value;
        }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [IgnoreDataMember]
        public string BestRatingText
        {
            get => this.BestRating as string;
            set => this.BestRating = value;
        }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [DataMember(Name = "ratingValue", Order = 4)]
        public object RatingValue { get; protected set; }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [IgnoreDataMember]
        public string RatingValueText
        {
            get => this.RatingValue as string;
            set => this.RatingValue = value;
        }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [IgnoreDataMember]
        public double? RatingValueNumber
        {
            get => this.RatingValue as double?;
            set => this.RatingValue = value;
        }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [DataMember(Name = "worstRating", Order = 5)]
        public object WorstRating { get; protected set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [IgnoreDataMember]
        public double? WorstRatingNumber
        {
            get => this.WorstRating as double?;
            set => this.WorstRating = value;
        }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [IgnoreDataMember]
        public string WorstRatingText
        {
            get => this.WorstRating as string;
            set => this.WorstRating = value;
        }
    }
}
