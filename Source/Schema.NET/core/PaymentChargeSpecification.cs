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
        OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        OneOrMany<PaymentMethod?> AppliesToPaymentMethod { get; set; }
    }

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    [DataContract]
    public partial class PaymentChargeSpecification : PriceSpecification, IPaymentChargeSpecification, IEquatable<PaymentChargeSpecification>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToPaymentMethod", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PaymentMethod?> AppliesToPaymentMethod { get; set; }

        /// <inheritdoc/>
        public bool Equals(PaymentChargeSpecification other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.AppliesToDeliveryMethod == other.AppliesToDeliveryMethod &&
                this.AppliesToPaymentMethod == other.AppliesToPaymentMethod &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PaymentChargeSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AppliesToDeliveryMethod)
            .And(this.AppliesToPaymentMethod)
            .And(base.GetHashCode());
    }
}
