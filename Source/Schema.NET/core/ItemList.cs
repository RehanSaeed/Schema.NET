using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    [DataContract]
    public partial class ItemList : Intangible
    {
        public interface IItemListElement : IWrapper { }
        public interface IItemListElement<T> : IItemListElement { new T Data { get; set; } }
        public class ItemListElementListItem : IItemListElement<ListItem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ListItem) value; } }
            public virtual ListItem Data { get; set; }
            public ItemListElementListItem () { }
            public ItemListElementListItem (ListItem data) { Data = data; }
            public static implicit operator ItemListElementListItem (ListItem data) { return new ItemListElementListItem (data); }
        }

        public class ItemListElementstring : IItemListElement<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ItemListElementstring () { }
            public ItemListElementstring (string data) { Data = data; }
            public static implicit operator ItemListElementstring (string data) { return new ItemListElementstring (data); }
        }

        public class ItemListElementThing : IItemListElement<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public ItemListElementThing () { }
            public ItemListElementThing (Thing data) { Data = data; }
            public static implicit operator ItemListElementThing (Thing data) { return new ItemListElementThing (data); }
        }


        public interface IItemListOrder : IWrapper { }
        public interface IItemListOrder<T> : IItemListOrder { new T Data { get; set; } }
        public class ItemListOrderItemListOrderType : IItemListOrder<ItemListOrderType>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ItemListOrderType) value; } }
            public virtual ItemListOrderType Data { get; set; }
            public ItemListOrderItemListOrderType () { }
            public ItemListOrderItemListOrderType (ItemListOrderType data) { Data = data; }
            public static implicit operator ItemListOrderItemListOrderType (ItemListOrderType data) { return new ItemListOrderItemListOrderType (data); }
        }

        public class ItemListOrderstring : IItemListOrder<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ItemListOrderstring () { }
            public ItemListOrderstring (string data) { Data = data; }
            public static implicit operator ItemListOrderstring (string data) { return new ItemListOrderstring (data); }
        }


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
        public Values<IItemListElement>? ItemListElement { get; set; } //ListItem, string, Thing

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IItemListOrder>? ItemListOrder { get; set; } //ItemListOrderType?, string

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [DataMember(Name = "numberOfItems", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? NumberOfItems { get; set; } 
    }
}
