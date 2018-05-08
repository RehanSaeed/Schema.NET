namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    public partial interface IComedyEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    [DataContract]
    public partial class ComedyEvent : Event, IComedyEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComedyEvent";
    }
}
