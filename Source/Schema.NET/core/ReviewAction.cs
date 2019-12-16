namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    public partial interface IReviewAction : IAssessAction
    {
        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        OneOrMany<IReview> ResultReview { get; set; }
    }

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    [DataContract]
    public partial class ReviewAction : AssessAction, IReviewAction, IEquatable<ReviewAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReviewAction";

        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        [DataMember(Name = "resultReview", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> ResultReview { get; set; }

        /// <inheritdoc/>
        public bool Equals(ReviewAction other)
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
                this.ResultReview == other.ResultReview &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ReviewAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ResultReview)
            .And(base.GetHashCode());
    }
}
