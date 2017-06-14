namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination...
    /// </summary>
    [DataContract]
    public partial class SendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SendAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod?>? DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Audience, Organization>? Recipient { get; set; }
    }
}
