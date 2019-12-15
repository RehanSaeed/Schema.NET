namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See BankAccount, InvestmentOrDeposit for more information.
    /// </summary>
    public partial interface IBankAccountAndInvestmentOrDeposit : IBankAccount, IInvestmentOrDeposit
    {
    }

    /// <summary>
    /// See BankAccount, InvestmentOrDeposit for more information.
    /// </summary>
    [DataContract]
    public abstract partial class BankAccountAndInvestmentOrDeposit : FinancialProduct, IBankAccountAndInvestmentOrDeposit, IEquatable<BankAccountAndInvestmentOrDeposit>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankAccountAndInvestmentOrDeposit";

        /// <summary>
        /// A minimum amount that has to be paid in every month.
        /// </summary>
        [DataMember(Name = "accountMinimumInflow", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMonetaryAmount> AccountMinimumInflow { get; set; }

        /// <summary>
        /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
        /// </summary>
        [DataMember(Name = "accountOverdraftLimit", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMonetaryAmount> AccountOverdraftLimit { get; set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?> Amount { get; set; }

        /// <summary>
        /// The type of a bank account.
        /// </summary>
        [DataMember(Name = "bankAccountType", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> BankAccountType { get; set; }

        /// <inheritdoc/>
        public bool Equals(BankAccountAndInvestmentOrDeposit other)
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
                this.AccountMinimumInflow == other.AccountMinimumInflow &&
                this.AccountOverdraftLimit == other.AccountOverdraftLimit &&
                this.Amount == other.Amount &&
                this.BankAccountType == other.BankAccountType &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BankAccountAndInvestmentOrDeposit);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AccountMinimumInflow)
            .And(this.AccountOverdraftLimit)
            .And(this.Amount)
            .And(this.BankAccountType)
            .And(base.GetHashCode());
    }
}
