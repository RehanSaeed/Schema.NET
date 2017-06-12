namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    [DataContract]
    public partial class InvestmentOrDeposit : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InvestmentOrDeposit";

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
    }
}
