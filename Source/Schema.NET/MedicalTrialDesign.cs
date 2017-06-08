namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Design models for medical trials. Enumerated type.
    /// </summary>
    [DataContract]
    public class MedicalTrialDesign : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalTrialDesign";
    }
}
