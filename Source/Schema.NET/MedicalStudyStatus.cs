namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The status of a medical study. Enumerated type.
    /// </summary>
    [DataContract]
    public class MedicalStudyStatus : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalStudyStatus";
    }
}
