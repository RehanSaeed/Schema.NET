namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// </summary>
    [DataContract]
    public class Specialty : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Specialty";
    }
}
