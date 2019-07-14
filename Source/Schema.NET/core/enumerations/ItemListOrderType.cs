namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
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
