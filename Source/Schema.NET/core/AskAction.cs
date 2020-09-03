namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IAskAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        OneOrMany<IQuestion> Question { get; set; }
    }

    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class AskAction : CommunicateAction, IAskAction, IEquatable<AskAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AskAction";

        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        [DataMember(Name = "question", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuestion> Question { get; set; }

        /// <inheritdoc/>
        public bool Equals(AskAction other)
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
                this.Question == other.Question &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AskAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Question)
            .And(base.GetHashCode());
    }
}
