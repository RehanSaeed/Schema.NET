namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract]
    public partial class Message : CreativeWork
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint, Organization, Person>? BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [DataMember(Name = "ccRecipient", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint, Organization, Person>? CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateRead", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateReceived", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [DataMember(Name = "dateSent", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [DataMember(Name = "messageAttachment", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWork>? MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, ContactPoint, Organization, Person>? Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, Organization, Person>? Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [DataMember(Name = "toRecipient", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, ContactPoint, Organization, Person>? ToRecipient { get; set; }
    }
}
