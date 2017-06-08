namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    [DataContract]
    public class PaymentService : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PaymentService";
    }
}
