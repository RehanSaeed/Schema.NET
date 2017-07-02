namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskEstimator : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskEstimator";

        /// <summary>
        /// The condition, complication, or symptom whose risk is being estimated.
        /// </summary>
        [DataMember(Name = "estimatesRiskOf", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity>? EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        [DataMember(Name = "includedRiskFactor", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalRiskFactor>? IncludedRiskFactor { get; set; }
    }
}
