namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    [DataContract]
    public class PayAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PayAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient")]
        public object Recipient { get; protected set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Person RecipientPerson
        {
            get => this.Recipient as Person;
            set => this.Recipient = value;
        }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Audience RecipientAudience
        {
            get => this.Recipient as Audience;
            set => this.Recipient = value;
        }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Organization RecipientOrganization
        {
            get => this.Recipient as Organization;
            set => this.Recipient = value;
        }
    }
}
