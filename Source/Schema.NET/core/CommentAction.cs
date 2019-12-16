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
        OneOrMany<IComment> ResultComment { get; set; }
    }

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    [DataContract]
    public partial class CommentAction : CommunicateAction, ICommentAction, IEquatable<CommentAction>
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
        public OneOrMany<IComment> ResultComment { get; set; }

        /// <inheritdoc/>
        public bool Equals(CommentAction other)
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
                this.ResultComment == other.ResultComment &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CommentAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ResultComment)
            .And(base.GetHashCode());
    }
}
