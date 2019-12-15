namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    public partial interface IMedicalRiskScore : IMedicalRiskEstimator
    {
        /// <summary>
        /// The algorithm or rules to follow to compute the score.
        /// </summary>
        OneOrMany<string> Algorithm { get; set; }
    }

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskScore : MedicalRiskEstimator, IMedicalRiskScore, IEquatable<MedicalRiskScore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskScore";

        /// <summary>
        /// The algorithm or rules to follow to compute the score.
        /// </summary>
        [DataMember(Name = "algorithm", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Algorithm { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalRiskScore other)
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
                this.Algorithm == other.Algorithm &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalRiskScore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Algorithm)
            .And(base.GetHashCode());
    }
}
