namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract]
    public partial class PublicationEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationEvent";

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public override OneOrMany<bool?>? IsAccessibleForFree { get; set; }

        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedBy", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<BroadcastService>? PublishedOn { get; set; }
    }
}
