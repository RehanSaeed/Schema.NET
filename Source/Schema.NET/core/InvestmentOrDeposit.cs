namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    public partial interface IInvestmentOrDeposit : IFinancialProduct
    {
        /// <summary>
        /// The amount of money.
        /// </summary>
        Values<IMonetaryAmount, decimal?> Amount { get; set; }
    }

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    [DataContract]
    public partial class InvestmentOrDeposit : FinancialProduct, IInvestmentOrDeposit, IEquatable<InvestmentOrDeposit>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InvestmentOrDeposit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?> Amount { get; set; }

        /// <inheritdoc/>
        public bool Equals(InvestmentOrDeposit other)
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
                this.Amount == other.Amount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as InvestmentOrDeposit);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Amount)
            .And(base.GetHashCode());
    }
}
