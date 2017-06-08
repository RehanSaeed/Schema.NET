namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Accountancy business.
    /// As a LocalBusiness it can be described as a provider of one or more Service(s).
    /// </summary>
    [DataContract]
    public class AccountingService : FinancialService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AccountingService";
    }
}
