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
    }
}
