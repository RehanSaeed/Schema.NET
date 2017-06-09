namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination...
    /// </summary>
    [DataContract]
    public class ReceiveAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReceiveAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 2)]
        public DeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 3)]
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
    }
}
