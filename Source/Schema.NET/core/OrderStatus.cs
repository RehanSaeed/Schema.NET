namespace Schema.NET
{
    /// <summary>
    /// Enumerated status values for Order.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// OrderStatus representing cancellation of an order.
        /// </summary>
        OrderCancelled,

        /// <summary>
        /// OrderStatus representing successful delivery of an order.
        /// </summary>
        OrderDelivered,

        /// <summary>
        /// OrderStatus representing that an order is in transit.
        /// </summary>
        OrderInTransit,

        /// <summary>
        /// OrderStatus representing that payment is due on an order.
        /// </summary>
        OrderPaymentDue,

        /// <summary>
        /// OrderStatus representing availability of an order for pickup.
        /// </summary>
        OrderPickupAvailable,

        /// <summary>
        /// OrderStatus representing that there is a problem with the order.
        /// </summary>
        OrderProblem,

        /// <summary>
        /// OrderStatus representing that an order is being processed.
        /// </summary>
        OrderProcessing,

        /// <summary>
        /// OrderStatus representing that an order has been returned.
        /// </summary>
        OrderReturned
    }
}
