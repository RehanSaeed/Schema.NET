namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Social event.
    /// </summary>
    public partial interface ISocialEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Social event.
    /// </summary>
    [DataContract]
    public partial class SocialEvent : Event, ISocialEvent, IEquatable<SocialEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SocialEvent";
    }
}
