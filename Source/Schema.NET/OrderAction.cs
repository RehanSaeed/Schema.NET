namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public class OrderAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OrderAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
    }
}
