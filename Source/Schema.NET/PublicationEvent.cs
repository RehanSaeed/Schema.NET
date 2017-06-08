namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e...
    /// </summary>
    [DataContract]
    public class PublicationEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PublicationEvent";

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn")]
        public BroadcastService PublishedOn { get; set; }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree")]
        public override bool IsAccessibleForFree { get; set; }
    }
}
