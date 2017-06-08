namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs...
    /// </summary>
    [DataContract]
    public class ItemList : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ItemList";

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [DataMember(Name = "itemListElement")]
        public object ItemListElement { get; protected set; }

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [IgnoreDataMember]
        public ListItem ItemListElementListItem
        {
            get => this.ItemListElement as ListItem;
            set => this.ItemListElement = value;
        }

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [IgnoreDataMember]
        public Thing ItemListElementThing
        {
            get => this.ItemListElement as Thing;
            set => this.ItemListElement = value;
        }

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;/p&gt;
        /// &lt;p&gt;Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;/p&gt;
        /// &lt;p&gt;Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [IgnoreDataMember]
        public string ItemListElementText
        {
            get => this.ItemListElement as string;
            set => this.ItemListElement = value;
        }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [DataMember(Name = "itemListOrder")]
        public object ItemListOrder { get; protected set; }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [IgnoreDataMember]
        public string ItemListOrderText
        {
            get => this.ItemListOrder as string;
            set => this.ItemListOrder = value;
        }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [IgnoreDataMember]
        public ItemListOrderType ItemListOrderItemListOrderType
        {
            get => this.ItemListOrder as ItemListOrderType;
            set => this.ItemListOrder = value;
        }

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [DataMember(Name = "numberOfItems")]
        public int NumberOfItems { get; set; }
    }
}
