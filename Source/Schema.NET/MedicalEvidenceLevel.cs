namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Level of evidence for a medical guideline. Enumerated type.
    /// </summary>
    [DataContract]
    public class MedicalEvidenceLevel : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalEvidenceLevel";
    }
}
