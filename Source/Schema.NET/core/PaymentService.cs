namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    public partial interface IPaymentService : IFinancialProduct
    {
    }

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    [DataContract]
    public partial class PaymentService : FinancialProduct, IPaymentService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentService";
    }
}
