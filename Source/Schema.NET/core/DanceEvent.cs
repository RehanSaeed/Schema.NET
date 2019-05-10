namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    public partial interface IDanceEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    [DataContract]
    public partial class DanceEvent : Event, IDanceEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DanceEvent";
    }
}
