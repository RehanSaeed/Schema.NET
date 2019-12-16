namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Financial services business.
    /// </summary>
    public partial interface IFinancialService : ILocalBusiness
    {
        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        Values<string, Uri> FeesAndCommissionsSpecification { get; set; }
    }

    /// <summary>
    /// Financial services business.
    /// </summary>
    [DataContract]
    public partial class FinancialService : LocalBusiness, IFinancialService, IEquatable<FinancialService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialService";

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FeesAndCommissionsSpecification { get; set; }

        /// <inheritdoc/>
        public bool Equals(FinancialService other)
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
                this.FeesAndCommissionsSpecification == other.FeesAndCommissionsSpecification &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FinancialService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.FeesAndCommissionsSpecification)
            .And(base.GetHashCode());
    }
}
