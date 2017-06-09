namespace Schema.NET
{
    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    public enum ItemAvailability
    {
        /// <summary>
        /// Indicates that the item has been discontinued.
        /// </summary>
        Discontinued,

        /// <summary>
        /// Indicates that the item is in stock.
        /// </summary>
        InStock,

        /// <summary>
        /// Indicates that the item is available only at physical locations.
        /// </summary>
        InStoreOnly,

        /// <summary>
        /// Indicates that the item has limited availability.
        /// </summary>
        LimitedAvailability,

        /// <summary>
        /// Indicates that the item is available only online.
        /// </summary>
        OnlineOnly,

        /// <summary>
        /// Indicates that the item is out of stock.
        /// </summary>
        OutOfStock,

        /// <summary>
        /// Indicates that the item is available for pre-order, but will be delivered when generally available.
        /// </summary>
        PreOrder,

        /// <summary>
        /// Indicates that the item is available for ordering and delivery before general availability.
        /// </summary>
        PreSale,

        /// <summary>
        /// Indicates that the item has sold out.
        /// </summary>
        SoldOut
    }
}
