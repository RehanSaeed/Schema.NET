namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    public partial interface IBankOrCreditUnion : IFinancialService
    {
    }

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    [DataContract]
    public partial class BankOrCreditUnion : FinancialService, IBankOrCreditUnion
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankOrCreditUnion";
    }
}
