namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer...
    /// </summary>
    public enum DeliveryMethod
    {
        /// <summary>
        /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
        /// </summary>
        [EnumMember(Value = "http://schema.org/OnSitePickup")]
        OnSitePickup
    }
}
