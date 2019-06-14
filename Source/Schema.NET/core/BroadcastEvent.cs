namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public partial interface IBroadcastEvent : IPublicationEvent
    {
        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        OneOrMany<IEvent, Event> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }
    }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    [DataContract]
    public partial class BroadcastEvent : PublicationEvent, IBroadcastEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastEvent";

        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [DataMember(Name = "broadcastOfEvent", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent, Event> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        [DataMember(Name = "isLiveBroadcast", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }
    }
}
