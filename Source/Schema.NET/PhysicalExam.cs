namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of physical examination of a patient performed by a physician.
    /// </summary>
    [DataContract]
    public class PhysicalExam : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PhysicalExam";
    }
}
