namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Systems of medical practice.
    /// </summary>
    [DataContract]
    public class MedicineSystem : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicineSystem";
    }
}
