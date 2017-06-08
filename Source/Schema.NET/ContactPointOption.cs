namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// </summary>
    [DataContract]
    public class ContactPointOption : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ContactPointOption";
    }
}
