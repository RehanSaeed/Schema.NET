namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    public partial interface IMessage : ICreativeWork
    {
        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        Values<IContactPoint, IOrganization, IPerson> BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        Values<IContactPoint, IOrganization, IPerson> CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        OneOrMany<DateTimeOffset?> DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        OneOrMany<DateTimeOffset?> DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        OneOrMany<ICreativeWork> MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        Values<IAudience, IOrganization, IPerson> Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> ToRecipient { get; set; }
    }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract]
    public partial class Message : CreativeWork, IMessage, IEquatable<Message>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Message";

        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        [DataMember(Name = "bccRecipient", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IOrganization, IPerson> BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [DataMember(Name = "ccRecipient", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IOrganization, IPerson> CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateRead", Order = 208)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateReceived", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [DataMember(Name = "dateSent", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [DataMember(Name = "messageAttachment", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IOrganization, IPerson> Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [DataMember(Name = "toRecipient", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> ToRecipient { get; set; }

        /// <inheritdoc/>
        public bool Equals(Message other)
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
                this.BccRecipient == other.BccRecipient &&
                this.CcRecipient == other.CcRecipient &&
                this.DateRead == other.DateRead &&
                this.DateReceived == other.DateReceived &&
                this.DateSent == other.DateSent &&
                this.MessageAttachment == other.MessageAttachment &&
                this.Recipient == other.Recipient &&
                this.Sender == other.Sender &&
                this.ToRecipient == other.ToRecipient &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Message);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BccRecipient)
            .And(this.CcRecipient)
            .And(this.DateRead)
            .And(this.DateReceived)
            .And(this.DateSent)
            .And(this.MessageAttachment)
            .And(this.Recipient)
            .And(this.Sender)
            .And(this.ToRecipient)
            .And(base.GetHashCode());
    }
}
