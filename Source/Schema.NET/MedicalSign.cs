namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    [DataContract]
    public class MedicalSign : MedicalSignOrSymptom
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalSign";
    }
}
