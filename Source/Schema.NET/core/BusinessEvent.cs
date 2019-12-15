namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    public partial interface IBusinessEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    [DataContract]
    public partial class BusinessEvent : Event, IBusinessEvent, IEquatable<BusinessEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessEvent";
    }
}
