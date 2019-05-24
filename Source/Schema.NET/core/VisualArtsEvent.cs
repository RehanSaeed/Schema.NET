namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    public partial interface IVisualArtsEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    [DataContract]
    public partial class VisualArtsEvent : Event, IVisualArtsEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtsEvent";
    }
}
