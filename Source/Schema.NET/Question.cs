namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    [DataContract]
    public class Question : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Question";

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount")]
        public int UpvoteCount { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        [DataMember(Name = "answerCount")]
        public int AnswerCount { get; set; }

        /// <summary>
        /// The answer that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        [DataMember(Name = "acceptedAnswer")]
        public Answer AcceptedAnswer { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        [DataMember(Name = "suggestedAnswer")]
        public Answer SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount")]
        public int DownvoteCount { get; set; }
    }
}
