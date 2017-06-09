namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    [DataContract]
    public class FinancialProduct : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialProduct";

        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [DataMember(Name = "annualPercentageRate", Order = 2)]
        public object AnnualPercentageRate { get; protected set; }

        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue AnnualPercentageRateQuantitativeValue
        {
            get => this.AnnualPercentageRate as QuantitativeValue;
            set => this.AnnualPercentageRate = value;
        }

        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [IgnoreDataMember]
        public double? AnnualPercentageRateNumber
        {
            get => this.AnnualPercentageRate as double?;
            set => this.AnnualPercentageRate = value;
        }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 3)]
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

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [DataMember(Name = "interestRate", Order = 4)]
        public object InterestRate { get; protected set; }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue InterestRateQuantitativeValue
        {
            get => this.InterestRate as QuantitativeValue;
            set => this.InterestRate = value;
        }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [IgnoreDataMember]
        public double? InterestRateNumber
        {
            get => this.InterestRate as double?;
            set => this.InterestRate = value;
        }
    }
}
