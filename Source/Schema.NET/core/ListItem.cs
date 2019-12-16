namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    public partial interface IListItem : IIntangible
    {
        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        OneOrMany<IThing> Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        OneOrMany<IListItem> NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        Values<int?, string> Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        OneOrMany<IListItem> PreviousItem { get; set; }
    }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract]
    public partial class ListItem : Intangible, IListItem, IEquatable<ListItem>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IListItem> NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IListItem> PreviousItem { get; set; }

        /// <inheritdoc/>
        public bool Equals(ListItem other)
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
                this.Item == other.Item &&
                this.NextItem == other.NextItem &&
                this.Position == other.Position &&
                this.PreviousItem == other.PreviousItem &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ListItem);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Item)
            .And(this.NextItem)
            .And(this.Position)
            .And(this.PreviousItem)
            .And(base.GetHashCode());
    }
}
