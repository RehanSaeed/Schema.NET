namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemAvailability
    {
        /// <summary>
        /// Indicates that the item has been discontinued.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Discontinued")]
        Discontinued,

        /// <summary>
        /// Indicates that the item is in stock.
        /// </summary>
        [EnumMember(Value = "https://schema.org/InStock")]
        InStock,

        /// <summary>
        /// Indicates that the item is available only at physical locations.
        /// </summary>
        [EnumMember(Value = "https://schema.org/InStoreOnly")]
        InStoreOnly,

        /// <summary>
        /// Indicates that the item has limited availability.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LimitedAvailability")]
        LimitedAvailability,

        /// <summary>
        /// Indicates that the item is available only online.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OnlineOnly")]
        OnlineOnly,

        /// <summary>
        /// Indicates that the item is out of stock.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OutOfStock")]
        OutOfStock,

        /// <summary>
        /// Indicates that the item is available for pre-order, but will be delivered when generally available.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PreOrder")]
        PreOrder,

        /// <summary>
        /// Indicates that the item is available for ordering and delivery before general availability.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PreSale")]
        PreSale,

        /// <summary>
        /// Indicates that the item has sold out.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SoldOut")]
        SoldOut,
    }
}
