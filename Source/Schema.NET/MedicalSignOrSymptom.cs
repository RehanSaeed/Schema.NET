namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
    [DataContract]
    public class MedicalSignOrSymptom : MedicalCondition
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalSignOrSymptom";
    }
}
