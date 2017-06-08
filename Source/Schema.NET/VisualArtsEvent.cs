namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    [DataContract]
    public class VisualArtsEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VisualArtsEvent";
    }
}
