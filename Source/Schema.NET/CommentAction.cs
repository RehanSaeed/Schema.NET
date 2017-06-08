namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    [DataContract]
    public class CommentAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CommentAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment")]
        public Comment ResultComment { get; set; }
    }
}
