namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e...
    /// </summary>
    [DataContract]
    public partial class MedicalRiskScore : MedicalRiskEstimator
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskScore";
    }
}
