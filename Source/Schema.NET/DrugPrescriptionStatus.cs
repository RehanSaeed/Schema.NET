namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether this drug is available by prescription or over-the-counter.
    /// </summary>
    [DataContract]
    public class DrugPrescriptionStatus : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DrugPrescriptionStatus";
    }
}
