namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IOrderAction : ITradeAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?>? DeliveryMethod { get; set; }
    }

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public partial class OrderAction : TradeAction, IOrderAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DeliveryMethod?>? DeliveryMethod { get; set; }
    }
}
