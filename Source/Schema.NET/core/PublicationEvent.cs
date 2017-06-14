namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e...
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
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<bool?>? IsAccessibleForFree { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BroadcastService>? PublishedOn { get; set; }
    }
}
