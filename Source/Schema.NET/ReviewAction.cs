namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience...
    /// </summary>
    [DataContract]
    public class ReviewAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ReviewAction";

        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        [DataMember(Name = "resultReview")]
        public Review ResultReview { get; set; }
    }
}
