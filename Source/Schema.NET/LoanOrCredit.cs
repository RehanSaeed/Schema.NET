namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    [DataContract]
    public class LoanOrCredit : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoanOrCredit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 2)]
        public object Amount { get; protected set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount AmountMonetaryAmount
        {
            get => this.Amount as MonetaryAmount;
            set => this.Amount = value;
        }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [IgnoreDataMember]
        public decimal? AmountNumber
        {
            get => this.Amount as decimal?;
            set => this.Amount = value;
        }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        [DataMember(Name = "loanTerm", Order = 3)]
        public QuantitativeValue LoanTerm { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [DataMember(Name = "requiredCollateral", Order = 4)]
        public object RequiredCollateral { get; protected set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [IgnoreDataMember]
        public string RequiredCollateralText
        {
            get => this.RequiredCollateral as string;
            set => this.RequiredCollateral = value;
        }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [IgnoreDataMember]
        public Thing RequiredCollateralThing
        {
            get => this.RequiredCollateral as Thing;
            set => this.RequiredCollateral = value;
        }
    }
}
