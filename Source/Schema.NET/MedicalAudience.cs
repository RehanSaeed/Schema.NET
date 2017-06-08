namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Target audiences for medical web pages. Enumerated type.
    /// </summary>
    [DataContract]
    public class MedicalAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalAudience";
    }
}
