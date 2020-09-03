namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
    public partial interface ICommunicateAction : IInteractAction
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
    [DataContract]
    public partial class CommunicateAction : InteractAction, ICommunicateAction, IEquatable<CommunicateAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CommunicateAction";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <inheritdoc/>
        public bool Equals(CommunicateAction other)
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
                this.About == other.About &&
                this.InLanguage == other.InLanguage &&
                this.Recipient == other.Recipient &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CommunicateAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.About)
            .And(this.InLanguage)
            .And(this.Recipient)
            .And(base.GetHashCode());
    }
}
