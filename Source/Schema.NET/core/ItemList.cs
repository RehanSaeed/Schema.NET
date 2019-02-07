namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    [DataContract]
    public partial class ItemList : Intangible
    {
        public interface IItemListElement : IValue {}
        public interface IItemListElement<T> : IItemListElement { new T Value { get; } }
        public class OneOrManyItemListElement : OneOrMany<IItemListElement>
        {
            public OneOrManyItemListElement(IItemListElement item) : base(item) { }
            public OneOrManyItemListElement(IEnumerable<IItemListElement> items) : base(items) { }
            public static implicit operator OneOrManyItemListElement (ListItem value) { return new OneOrManyItemListElement (new ItemListElementListItem (value)); }
            public static implicit operator OneOrManyItemListElement (ListItem[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementListItem (v))); }
            public static implicit operator OneOrManyItemListElement (List<ListItem> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementListItem (v))); }
            public static implicit operator OneOrManyItemListElement (string value) { return new OneOrManyItemListElement (new ItemListElementstring (value)); }
            public static implicit operator OneOrManyItemListElement (string[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementstring (v))); }
            public static implicit operator OneOrManyItemListElement (List<string> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementstring (v))); }
            public static implicit operator OneOrManyItemListElement (Thing value) { return new OneOrManyItemListElement (new ItemListElementThing (value)); }
            public static implicit operator OneOrManyItemListElement (Thing[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementThing (v))); }
            public static implicit operator OneOrManyItemListElement (List<Thing> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementThing (v))); }
        }
        public struct ItemListElementListItem : IItemListElement<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public ItemListElementListItem (ListItem value) { Value = value; }
            public static implicit operator ItemListElementListItem (ListItem value) { return new ItemListElementListItem (value); }
        }
        public struct ItemListElementstring : IItemListElement<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ItemListElementstring (string value) { Value = value; }
            public static implicit operator ItemListElementstring (string value) { return new ItemListElementstring (value); }
        }
        public struct ItemListElementThing : IItemListElement<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ItemListElementThing (Thing value) { Value = value; }
            public static implicit operator ItemListElementThing (Thing value) { return new ItemListElementThing (value); }
        }

        public interface IItemListOrder : IValue {}
        public interface IItemListOrder<T> : IItemListOrder { new T Value { get; } }
        public class OneOrManyItemListOrder : OneOrMany<IItemListOrder>
        {
            public OneOrManyItemListOrder(IItemListOrder item) : base(item) { }
            public OneOrManyItemListOrder(IEnumerable<IItemListOrder> items) : base(items) { }
            public static implicit operator OneOrManyItemListOrder (ItemListOrderType value) { return new OneOrManyItemListOrder (new ItemListOrderItemListOrderType (value)); }
            public static implicit operator OneOrManyItemListOrder (ItemListOrderType[] values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderItemListOrderType (v))); }
            public static implicit operator OneOrManyItemListOrder (List<ItemListOrderType> values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderItemListOrderType (v))); }
            public static implicit operator OneOrManyItemListOrder (string value) { return new OneOrManyItemListOrder (new ItemListOrderstring (value)); }
            public static implicit operator OneOrManyItemListOrder (string[] values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderstring (v))); }
            public static implicit operator OneOrManyItemListOrder (List<string> values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderstring (v))); }
        }
        public struct ItemListOrderItemListOrderType : IItemListOrder<ItemListOrderType>
        {
            object IValue.Value => this.Value;
            public ItemListOrderType Value { get; }
            public ItemListOrderItemListOrderType (ItemListOrderType value) { Value = value; }
            public static implicit operator ItemListOrderItemListOrderType (ItemListOrderType value) { return new ItemListOrderItemListOrderType (value); }
        }
        public struct ItemListOrderstring : IItemListOrder<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ItemListOrderstring (string value) { Value = value; }
            public static implicit operator ItemListOrderstring (string value) { return new ItemListOrderstring (value); }
        }

        public interface INumberOfItems : IValue {}
        public interface INumberOfItems<T> : INumberOfItems { new T Value { get; } }
        public class OneOrManyNumberOfItems : OneOrMany<INumberOfItems>
        {
            public OneOrManyNumberOfItems(INumberOfItems item) : base(item) { }
            public OneOrManyNumberOfItems(IEnumerable<INumberOfItems> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfItems (int value) { return new OneOrManyNumberOfItems (new NumberOfItemsint (value)); }
            public static implicit operator OneOrManyNumberOfItems (int[] values) { return new OneOrManyNumberOfItems (values.Select(v => (INumberOfItems) new NumberOfItemsint (v))); }
            public static implicit operator OneOrManyNumberOfItems (List<int> values) { return new OneOrManyNumberOfItems (values.Select(v => (INumberOfItems) new NumberOfItemsint (v))); }
        }
        public struct NumberOfItemsint : INumberOfItems<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfItemsint (int value) { Value = value; }
            public static implicit operator NumberOfItemsint (int value) { return new NumberOfItemsint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ItemList";

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
        /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
        /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [DataMember(Name = "itemListElement", Order = 206)]
        public OneOrManyItemListElement ItemListElement { get; set; }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 207)]
        public OneOrManyItemListOrder ItemListOrder { get; set; }

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [DataMember(Name = "numberOfItems", Order = 208)]
        public OneOrManyNumberOfItems NumberOfItems { get; set; }
    }
}
