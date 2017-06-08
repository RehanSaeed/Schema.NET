namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    [DataContract]
    public class Review : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Review";

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        [DataMember(Name = "reviewRating")]
        public Rating ReviewRating { get; set; }

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        [DataMember(Name = "reviewBody")]
        public string ReviewBody { get; set; }
    }
}
