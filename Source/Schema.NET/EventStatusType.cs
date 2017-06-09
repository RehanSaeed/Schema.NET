namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// </summary>
    [DataContract]
    public class EventStatusType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EventStatusType";
    }
}
