namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An Insurance agency.
    /// </summary>
    public partial interface IInsuranceAgency : IFinancialService
    {
    }

    /// <summary>
    /// An Insurance agency.
    /// </summary>
    [DataContract]
    public partial class InsuranceAgency : FinancialService, IInsuranceAgency
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InsuranceAgency";
    }
}
