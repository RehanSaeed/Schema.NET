namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A series of Events. Included events can relate with the series using the superEvent property...
    /// </summary>
    [DataContract]
    public class EventSeries : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EventSeries";
    }
}
