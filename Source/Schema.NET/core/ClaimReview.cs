namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
    [DataContract]
    public partial class ClaimReview : Review
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ClaimReview";

        /// <summary>
        /// A short summary of the specific claims reviewed in a ClaimReview.
        /// </summary>
        [DataMember(Name = "claimReviewed", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ClaimReviewed { get; set; }
    }
}
