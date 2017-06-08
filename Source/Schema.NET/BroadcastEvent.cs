namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    [DataContract]
    public class BroadcastEvent : PublicationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BroadcastEvent";

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat")]
        public string VideoFormat { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        [DataMember(Name = "isLiveBroadcast")]
        public bool IsLiveBroadcast { get; set; }

        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [DataMember(Name = "broadcastOfEvent")]
        public Event BroadcastOfEvent { get; set; }
    }
}
