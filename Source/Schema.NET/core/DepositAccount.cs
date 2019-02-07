namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// </summary>
    [DataContract]
    public partial class DepositAccount : BankAccountAndInvestmentOrDeposit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepositAccount";
    }
}
