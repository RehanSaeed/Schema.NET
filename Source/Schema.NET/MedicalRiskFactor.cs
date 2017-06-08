namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    [DataContract]
    public class MedicalRiskFactor : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalRiskFactor";
    }
}
