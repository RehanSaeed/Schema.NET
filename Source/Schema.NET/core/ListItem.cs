namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract]
    public partial class ListItem : Intangible
    {
        public interface IItem : IValue {}
        public interface IItem<T> : IItem { new T Value { get; } }
        public class OneOrManyItem : OneOrMany<IItem>
        {
            public OneOrManyItem(IItem item) : base(item) { }
            public OneOrManyItem(IEnumerable<IItem> items) : base(items) { }
            public static implicit operator OneOrManyItem (Thing value) { return new OneOrManyItem (new ItemThing (value)); }
            public static implicit operator OneOrManyItem (Thing[] values) { return new OneOrManyItem (values.Select(v => (IItem) new ItemThing (v))); }
            public static implicit operator OneOrManyItem (List<Thing> values) { return new OneOrManyItem (values.Select(v => (IItem) new ItemThing (v))); }
        }
        public struct ItemThing : IItem<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ItemThing (Thing value) { Value = value; }
            public static implicit operator ItemThing (Thing value) { return new ItemThing (value); }
        }

        public interface INextItem : IValue {}
        public interface INextItem<T> : INextItem { new T Value { get; } }
        public class OneOrManyNextItem : OneOrMany<INextItem>
        {
            public OneOrManyNextItem(INextItem item) : base(item) { }
            public OneOrManyNextItem(IEnumerable<INextItem> items) : base(items) { }
            public static implicit operator OneOrManyNextItem (ListItem value) { return new OneOrManyNextItem (new NextItemListItem (value)); }
            public static implicit operator OneOrManyNextItem (ListItem[] values) { return new OneOrManyNextItem (values.Select(v => (INextItem) new NextItemListItem (v))); }
            public static implicit operator OneOrManyNextItem (List<ListItem> values) { return new OneOrManyNextItem (values.Select(v => (INextItem) new NextItemListItem (v))); }
        }
        public struct NextItemListItem : INextItem<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public NextItemListItem (ListItem value) { Value = value; }
            public static implicit operator NextItemListItem (ListItem value) { return new NextItemListItem (value); }
        }

        public interface IPosition : IValue {}
        public interface IPosition<T> : IPosition { new T Value { get; } }
        public class OneOrManyPosition : OneOrMany<IPosition>
        {
            public OneOrManyPosition(IPosition item) : base(item) { }
            public OneOrManyPosition(IEnumerable<IPosition> items) : base(items) { }
            public static implicit operator OneOrManyPosition (int value) { return new OneOrManyPosition (new Positionint (value)); }
            public static implicit operator OneOrManyPosition (int[] values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionint (v))); }
            public static implicit operator OneOrManyPosition (List<int> values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionint (v))); }
            public static implicit operator OneOrManyPosition (string value) { return new OneOrManyPosition (new Positionstring (value)); }
            public static implicit operator OneOrManyPosition (string[] values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionstring (v))); }
            public static implicit operator OneOrManyPosition (List<string> values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionstring (v))); }
        }
        public struct Positionint : IPosition<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public Positionint (int value) { Value = value; }
            public static implicit operator Positionint (int value) { return new Positionint (value); }
        }
        public struct Positionstring : IPosition<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Positionstring (string value) { Value = value; }
            public static implicit operator Positionstring (string value) { return new Positionstring (value); }
        }

        public interface IPreviousItem : IValue {}
        public interface IPreviousItem<T> : IPreviousItem { new T Value { get; } }
        public class OneOrManyPreviousItem : OneOrMany<IPreviousItem>
        {
            public OneOrManyPreviousItem(IPreviousItem item) : base(item) { }
            public OneOrManyPreviousItem(IEnumerable<IPreviousItem> items) : base(items) { }
            public static implicit operator OneOrManyPreviousItem (ListItem value) { return new OneOrManyPreviousItem (new PreviousItemListItem (value)); }
            public static implicit operator OneOrManyPreviousItem (ListItem[] values) { return new OneOrManyPreviousItem (values.Select(v => (IPreviousItem) new PreviousItemListItem (v))); }
            public static implicit operator OneOrManyPreviousItem (List<ListItem> values) { return new OneOrManyPreviousItem (values.Select(v => (IPreviousItem) new PreviousItemListItem (v))); }
        }
        public struct PreviousItemListItem : IPreviousItem<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public PreviousItemListItem (ListItem value) { Value = value; }
            public static implicit operator PreviousItemListItem (ListItem value) { return new PreviousItemListItem (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 206)]
        public OneOrManyItem Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 207)]
        public OneOrManyNextItem NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 208)]
        public OneOrManyPosition Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 209)]
        public OneOrManyPreviousItem PreviousItem { get; set; }
    }
}
