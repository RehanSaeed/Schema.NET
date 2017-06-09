namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract]
    public class ListItem : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 2)]
        public Thing Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 3)]
        public ListItem NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 4)]
        public object Position { get; protected set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [IgnoreDataMember]
        public int? PositionInteger
        {
            get => this.Position as int?;
            set => this.Position = value;
        }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [IgnoreDataMember]
        public string PositionText
        {
            get => this.Position as string;
            set => this.Position = value;
        }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 5)]
        public ListItem PreviousItem { get; set; }
    }
}
