namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract]
    public class Message : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Message";

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateRead")]
        public DateTimeOffset DateRead { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [DataMember(Name = "dateSent")]
        public DateTimeOffset DateSent { get; set; }

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

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender")]
        public object Sender { get; protected set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Person SenderPerson
        {
            get => this.Sender as Person;
            set => this.Sender = value;
        }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Organization SenderOrganization
        {
            get => this.Sender as Organization;
            set => this.Sender = value;
        }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [IgnoreDataMember]
        public Audience SenderAudience
        {
            get => this.Sender as Audience;
            set => this.Sender = value;
        }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [DataMember(Name = "messageAttachment")]
        public CreativeWork MessageAttachment { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateReceived")]
        public DateTimeOffset DateReceived { get; set; }
    }
}
