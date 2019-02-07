namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
    [DataContract]
    public partial class ClaimReview : Review
    {
        public interface IClaimReviewed : IValue {}
        public interface IClaimReviewed<T> : IClaimReviewed { new T Value { get; } }
        public class OneOrManyClaimReviewed : OneOrMany<IClaimReviewed>
        {
            public OneOrManyClaimReviewed(IClaimReviewed item) : base(item) { }
            public OneOrManyClaimReviewed(IEnumerable<IClaimReviewed> items) : base(items) { }
            public static implicit operator OneOrManyClaimReviewed (string value) { return new OneOrManyClaimReviewed (new ClaimReviewedstring (value)); }
            public static implicit operator OneOrManyClaimReviewed (string[] values) { return new OneOrManyClaimReviewed (values.Select(v => (IClaimReviewed) new ClaimReviewedstring (v))); }
            public static implicit operator OneOrManyClaimReviewed (List<string> values) { return new OneOrManyClaimReviewed (values.Select(v => (IClaimReviewed) new ClaimReviewedstring (v))); }
        }
        public struct ClaimReviewedstring : IClaimReviewed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ClaimReviewedstring (string value) { Value = value; }
            public static implicit operator ClaimReviewedstring (string value) { return new ClaimReviewedstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ClaimReview";

        /// <summary>
        /// A short summary of the specific claims reviewed in a ClaimReview.
        /// </summary>
        [DataMember(Name = "claimReviewed", Order = 306)]
        public OneOrManyClaimReviewed ClaimReviewed { get; set; }
    }
}
