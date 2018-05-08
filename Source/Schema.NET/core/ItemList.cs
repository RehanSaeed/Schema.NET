namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    public partial interface IItemList : IIntangible
    {
        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        Values<IListItem, string, IThing>? ItemListElement { get; set; }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        Values<ItemListOrderType?, string>? ItemListOrder { get; set; }

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        OneOrMany<int?>? NumberOfItems { get; set; }
    }

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    [DataContract]
    public partial class ItemList : Intangible, IItemList
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ItemList";

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [DataMember(Name = "itemListElement", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IListItem, string, IThing>? ItemListElement { get; set; }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ItemListOrderType?, string>? ItemListOrder { get; set; }

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [DataMember(Name = "numberOfItems", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfItems { get; set; }
    }
}
