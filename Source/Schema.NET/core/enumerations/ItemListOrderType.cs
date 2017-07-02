namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// </summary>
    public enum ItemListOrderType
    {
        /// <summary>
        /// An ItemList ordered with lower values listed first.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ItemListOrderAscending")]
        ItemListOrderAscending,

        /// <summary>
        /// An ItemList ordered with higher values listed first.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ItemListOrderDescending")]
        ItemListOrderDescending,

        /// <summary>
        /// An ItemList ordered with no explicit order.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ItemListUnordered")]
        ItemListUnordered
    }
}
