namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// </summary>
    public partial interface IMedicalRiskCalculator : IMedicalRiskEstimator
    {
    }

    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskCalculator : MedicalRiskEstimator, IMedicalRiskCalculator, IEquatable<MedicalRiskCalculator>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskCalculator";

        /// <inheritdoc/>
        public bool Equals(MedicalRiskCalculator other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalRiskCalculator);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
