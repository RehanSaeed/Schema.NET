namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Financial services business.
    /// </summary>
    [DataContract]
    public partial class FinancialService : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialService";

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 2)]
        public object FeesAndCommissionsSpecification { get; protected set; }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [IgnoreDataMember]
        public string FeesAndCommissionsSpecificationText
        {
            get => this.FeesAndCommissionsSpecification as string;
            set => this.FeesAndCommissionsSpecification = value;
        }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [IgnoreDataMember]
        public Uri FeesAndCommissionsSpecificationURL
        {
            get => this.FeesAndCommissionsSpecification as Uri;
            set => this.FeesAndCommissionsSpecification = value;
        }
    }
}
