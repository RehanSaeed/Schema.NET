namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    [DataContract]
    public partial class ReviewAction : AssessAction
    {
        public interface IResultReview : IValue {}
        public interface IResultReview<T> : IResultReview { new T Value { get; } }
        public class OneOrManyResultReview : OneOrMany<IResultReview>
        {
            public OneOrManyResultReview(IResultReview item) : base(item) { }
            public OneOrManyResultReview(IEnumerable<IResultReview> items) : base(items) { }
            public static implicit operator OneOrManyResultReview (Review value) { return new OneOrManyResultReview (new ResultReviewReview (value)); }
            public static implicit operator OneOrManyResultReview (Review[] values) { return new OneOrManyResultReview (values.Select(v => (IResultReview) new ResultReviewReview (v))); }
            public static implicit operator OneOrManyResultReview (List<Review> values) { return new OneOrManyResultReview (values.Select(v => (IResultReview) new ResultReviewReview (v))); }
        }
        public struct ResultReviewReview : IResultReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ResultReviewReview (Review value) { Value = value; }
            public static implicit operator ResultReviewReview (Review value) { return new ResultReviewReview (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReviewAction";

        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        [DataMember(Name = "resultReview", Order = 306)]
        public OneOrManyResultReview ResultReview { get; set; }
    }
}
