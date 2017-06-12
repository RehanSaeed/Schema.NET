namespace Schema.NET
{
    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// </summary>
    public enum ItemListOrderType
    {
        /// <summary>
        /// An ItemList ordered with lower values listed first.
        /// </summary>
        ItemListOrderAscending,

        /// <summary>
        /// An ItemList ordered with higher values listed first.
        /// </summary>
        ItemListOrderDescending,

        /// <summary>
        /// An ItemList ordered with no explicit order.
        /// </summary>
        ItemListUnordered
    }
}
