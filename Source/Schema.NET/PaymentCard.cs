namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
    [DataContract]
    public class PaymentCard : PaymentMethod
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentCard";
    }
}
