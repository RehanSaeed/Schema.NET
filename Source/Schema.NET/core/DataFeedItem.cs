namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    public partial interface IDataFeedItem : IIntangible
    {
        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        OneOrMany<IThing> Item { get; set; }
    }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    [DataContract]
    public partial class DataFeedItem : Intangible, IDataFeedItem, IEquatable<DataFeedItem>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeedItem";

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 206)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        [DataMember(Name = "dateDeleted", Order = 207)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 208)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Item { get; set; }

        /// <inheritdoc/>
        public bool Equals(DataFeedItem other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.DateCreated == other.DateCreated &&
                this.DateDeleted == other.DateDeleted &&
                this.DateModified == other.DateModified &&
                this.Item == other.Item &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DataFeedItem);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DateCreated)
            .And(this.DateDeleted)
            .And(this.DateModified)
            .And(this.Item)
            .And(base.GetHashCode());
    }
}
