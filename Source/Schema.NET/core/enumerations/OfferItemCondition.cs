namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A list of possible conditions for the item.
    /// </summary>
    public enum OfferItemCondition
    {
        /// <summary>
        /// Indicates that the item is damaged.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DamagedCondition")]
        DamagedCondition,

        /// <summary>
        /// Indicates that the item is new.
        /// </summary>
        [EnumMember(Value = "http://schema.org/NewCondition")]
        NewCondition,

        /// <summary>
        /// Indicates that the item is refurbished.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RefurbishedCondition")]
        RefurbishedCondition,

        /// <summary>
        /// Indicates that the item is used.
        /// </summary>
        [EnumMember(Value = "http://schema.org/UsedCondition")]
        UsedCondition
    }
}
