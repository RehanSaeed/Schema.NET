namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Design models for observational medical studies. Enumerated type.
    /// </summary>
    [DataContract]
    public class MedicalObservationalStudyDesign : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalObservationalStudyDesign";
    }
}
