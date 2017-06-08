namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    [DataContract]
    public class MedicalConditionStage : MedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalConditionStage";
    }
}
