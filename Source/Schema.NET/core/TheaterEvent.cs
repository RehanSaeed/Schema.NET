namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    public partial interface ITheaterEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    [DataContract]
    public partial class TheaterEvent : Event, ITheaterEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TheaterEvent";
    }
}
