namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    [DataContract]
    public class PaymentChargeSpecification : PriceSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PaymentChargeSpecification";

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToPaymentMethod")]
        public PaymentMethod AppliesToPaymentMethod { get; set; }

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod")]
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }
    }
}
