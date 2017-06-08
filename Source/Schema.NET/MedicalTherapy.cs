namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies...
    /// </summary>
    [DataContract]
    public class MedicalTherapy : TherapeuticProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalTherapy";
    }
}
