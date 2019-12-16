namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// </summary>
    public partial interface IDepositAccount : IBankAccountAndInvestmentOrDeposit
    {
    }

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// </summary>
    [DataContract]
    public partial class DepositAccount : BankAccountAndInvestmentOrDeposit, IDepositAccount, IEquatable<DepositAccount>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepositAccount";

        /// <inheritdoc/>
        public bool Equals(DepositAccount other)
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
        public override bool Equals(object obj) => this.Equals(obj as DepositAccount);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
