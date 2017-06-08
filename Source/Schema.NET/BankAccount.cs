namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
    [DataContract]
    public class BankAccount : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BankAccount";
    }
}
