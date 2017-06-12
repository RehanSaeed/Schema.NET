namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis...
    /// </summary>
    [DataContract]
    public class MedicalRiskCalculator : MedicalRiskEstimator
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskCalculator";
    }
}
