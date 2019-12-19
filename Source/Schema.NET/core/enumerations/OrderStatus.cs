namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Enumerated status values for Order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderStatus
    {
        /// <summary>
        /// OrderStatus representing cancellation of an order.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderCancelled")]
        OrderCancelled,

        /// <summary>
        /// OrderStatus representing successful delivery of an order.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderDelivered")]
        OrderDelivered,

        /// <summary>
        /// OrderStatus representing that an order is in transit.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderInTransit")]
        OrderInTransit,

        /// <summary>
        /// OrderStatus representing that payment is due on an order.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderPaymentDue")]
        OrderPaymentDue,

        /// <summary>
        /// OrderStatus representing availability of an order for pickup.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderPickupAvailable")]
        OrderPickupAvailable,

        /// <summary>
        /// OrderStatus representing that there is a problem with the order.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderProblem")]
        OrderProblem,

        /// <summary>
        /// OrderStatus representing that an order is being processed.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderProcessing")]
        OrderProcessing,

        /// <summary>
        /// OrderStatus representing that an order has been returned.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OrderReturned")]
        OrderReturned,
    }
}
