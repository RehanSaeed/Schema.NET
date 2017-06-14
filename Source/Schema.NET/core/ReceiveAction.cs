namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination...
    /// </summary>
    [DataContract]
    public partial class ReceiveAction : TransferAction
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod?>? DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization, Audience>? Sender { get; set; }
    }
}
