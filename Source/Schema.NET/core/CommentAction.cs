namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    public partial interface ICommentAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        OneOrMany<IComment, Comment> ResultComment { get; set; }
    }

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    [DataContract]
    public partial class CommentAction : CommunicateAction, ICommentAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CommentAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment, Comment> ResultComment { get; set; }
    }
}
