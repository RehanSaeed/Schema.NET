namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract]
    public partial class ListItem : Intangible
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ListItem>? NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ListItem>? PreviousItem { get; set; }
    }
}
