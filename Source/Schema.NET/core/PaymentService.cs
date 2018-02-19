using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    [DataContract]
    public partial class PaymentService : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentService";
    }
}
