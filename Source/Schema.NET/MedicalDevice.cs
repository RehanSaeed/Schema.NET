namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
    [DataContract]
    public class MedicalDevice : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalDevice";
    }
}
