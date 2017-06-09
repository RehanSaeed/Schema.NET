namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// </summary>
    [DataContract]
    public class RsvpResponseType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RsvpResponseType";
    }
}
