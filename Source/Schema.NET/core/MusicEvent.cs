namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    public partial interface IMusicEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    [DataContract]
    public partial class MusicEvent : Event, IMusicEvent, IEquatable<MusicEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicEvent";
    }
}
