namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public class PhysicalTherapy : MedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PhysicalTherapy";
    }
}
