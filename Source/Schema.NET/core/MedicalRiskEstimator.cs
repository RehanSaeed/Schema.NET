namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    public partial interface IMedicalRiskEstimator : IMedicalEntity
    {
        /// <summary>
        /// The condition, complication, or symptom whose risk is being estimated.
        /// </summary>
        OneOrMany<IMedicalEntity> EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        OneOrMany<IMedicalRiskFactor> IncludedRiskFactor { get; set; }
    }

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskEstimator : MedicalEntity, IMedicalRiskEstimator, IEquatable<MedicalRiskEstimator>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        [DataMember(Name = "includedRiskFactor", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalRiskFactor> IncludedRiskFactor { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalRiskEstimator other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.EstimatesRiskOf == other.EstimatesRiskOf &&
                this.IncludedRiskFactor == other.IncludedRiskFactor &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalRiskEstimator);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EstimatesRiskOf)
            .And(this.IncludedRiskFactor)
            .And(base.GetHashCode());
    }
}
