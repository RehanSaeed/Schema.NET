namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    [DataContract]
    public partial class Question : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Question";

        /// <summary>
        /// The answer that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        [DataMember(Name = "acceptedAnswer", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Answer>? AcceptedAnswer { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        [DataMember(Name = "answerCount", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? AnswerCount { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? DownvoteCount { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        [DataMember(Name = "suggestedAnswer", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Answer>? SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? UpvoteCount { get; set; }
    }
}
