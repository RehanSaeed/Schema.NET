namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination...
    /// </summary>
    [DataContract]
    public class SendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SendAction";

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
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
    }
}
