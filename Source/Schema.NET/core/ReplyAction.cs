namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="https://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IReplyAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        OneOrMany<IComment> ResultComment { get; set; }
    }

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="https://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ReplyAction : CommunicateAction, IReplyAction, IEquatable<ReplyAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReplyAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> ResultComment { get; set; }

        /// <inheritdoc/>
        public bool Equals(ReplyAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ReplyAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ResultComment)
            .And(base.GetHashCode());
    }
}
