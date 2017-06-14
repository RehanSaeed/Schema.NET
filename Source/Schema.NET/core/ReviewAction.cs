namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience...
    /// </summary>
    [DataContract]
    public partial class ReviewAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReviewAction";

        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        [DataMember(Name = "resultReview", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? ResultReview { get; set; }
    }
}
