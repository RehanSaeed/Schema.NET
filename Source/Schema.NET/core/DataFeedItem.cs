namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    [DataContract]
    public partial class DataFeedItem : Intangible
    {
        public interface IDateCreated : IValue {}
        public interface IDateCreated<T> : IDateCreated { new T Value { get; } }
        public class OneOrManyDateCreated : OneOrMany<IDateCreated>
        {
            public OneOrManyDateCreated(IDateCreated item) : base(item) { }
            public OneOrManyDateCreated(IEnumerable<IDateCreated> items) : base(items) { }
            public static implicit operator OneOrManyDateCreated (DateTimeOffset value) { return new OneOrManyDateCreated (new DateCreatedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateCreated (DateTimeOffset[] values) { return new OneOrManyDateCreated (values.Select(v => (IDateCreated) new DateCreatedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateCreated (List<DateTimeOffset> values) { return new OneOrManyDateCreated (values.Select(v => (IDateCreated) new DateCreatedDateTimeOffset (v))); }
        }
        public struct DateCreatedDateTimeOffset : IDateCreated<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateCreatedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateCreatedDateTimeOffset (DateTimeOffset value) { return new DateCreatedDateTimeOffset (value); }
        }

        public interface IDateDeleted : IValue {}
        public interface IDateDeleted<T> : IDateDeleted { new T Value { get; } }
        public class OneOrManyDateDeleted : OneOrMany<IDateDeleted>
        {
            public OneOrManyDateDeleted(IDateDeleted item) : base(item) { }
            public OneOrManyDateDeleted(IEnumerable<IDateDeleted> items) : base(items) { }
            public static implicit operator OneOrManyDateDeleted (DateTimeOffset value) { return new OneOrManyDateDeleted (new DateDeletedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateDeleted (DateTimeOffset[] values) { return new OneOrManyDateDeleted (values.Select(v => (IDateDeleted) new DateDeletedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateDeleted (List<DateTimeOffset> values) { return new OneOrManyDateDeleted (values.Select(v => (IDateDeleted) new DateDeletedDateTimeOffset (v))); }
        }
        public struct DateDeletedDateTimeOffset : IDateDeleted<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateDeletedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateDeletedDateTimeOffset (DateTimeOffset value) { return new DateDeletedDateTimeOffset (value); }
        }

        public interface IDateModified : IValue {}
        public interface IDateModified<T> : IDateModified { new T Value { get; } }
        public class OneOrManyDateModified : OneOrMany<IDateModified>
        {
            public OneOrManyDateModified(IDateModified item) : base(item) { }
            public OneOrManyDateModified(IEnumerable<IDateModified> items) : base(items) { }
            public static implicit operator OneOrManyDateModified (DateTimeOffset value) { return new OneOrManyDateModified (new DateModifiedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateModified (DateTimeOffset[] values) { return new OneOrManyDateModified (values.Select(v => (IDateModified) new DateModifiedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateModified (List<DateTimeOffset> values) { return new OneOrManyDateModified (values.Select(v => (IDateModified) new DateModifiedDateTimeOffset (v))); }
        }
        public struct DateModifiedDateTimeOffset : IDateModified<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateModifiedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateModifiedDateTimeOffset (DateTimeOffset value) { return new DateModifiedDateTimeOffset (value); }
        }

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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeedItem";

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 206)]
        public OneOrManyDateCreated DateCreated { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        [DataMember(Name = "dateDeleted", Order = 207)]
        public OneOrManyDateDeleted DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 208)]
        public OneOrManyDateModified DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 209)]
        public OneOrManyItem Item { get; set; }
    }
}
