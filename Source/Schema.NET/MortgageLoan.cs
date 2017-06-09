namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A loan in which property or real estate is used as collateral...
    /// </summary>
    [DataContract]
    public class MortgageLoan : LoanOrCredit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MortgageLoan";
    }
}
