namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    public partial interface ISaleEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    [DataContract]
    public partial class SaleEvent : Event, ISaleEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SaleEvent";
    }
}
