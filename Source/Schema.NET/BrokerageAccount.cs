namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An account that allows an investor to deposit funds and place investment orders with a licensed broker or brokerage firm.
    /// </summary>
    [DataContract]
    public class BrokerageAccount : InvestmentOrDeposit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BrokerageAccount";
    }
}
