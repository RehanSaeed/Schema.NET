namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    public partial interface ILiteraryEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    [DataContract]
    public partial class LiteraryEvent : Event, ILiteraryEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiteraryEvent";
    }
}
