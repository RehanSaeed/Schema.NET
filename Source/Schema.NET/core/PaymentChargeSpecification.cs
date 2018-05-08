namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    public partial interface IPaymentChargeSpecification : IPriceSpecification
    {
        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        OneOrMany<DeliveryMethod?>? AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        OneOrMany<PaymentMethod?>? AppliesToPaymentMethod { get; set; }
    }

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    [DataContract]
    public partial class PaymentChargeSpecification : PriceSpecification, IPaymentChargeSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DeliveryMethod?>? AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToPaymentMethod", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<PaymentMethod?>? AppliesToPaymentMethod { get; set; }
    }
}
