namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    [DataContract]
    public partial class PaymentChargeSpecification : PriceSpecification
    {
        public interface IAppliesToDeliveryMethod : IValue {}
        public interface IAppliesToDeliveryMethod<T> : IAppliesToDeliveryMethod { new T Value { get; } }
        public class OneOrManyAppliesToDeliveryMethod : OneOrMany<IAppliesToDeliveryMethod>
        {
            public OneOrManyAppliesToDeliveryMethod(IAppliesToDeliveryMethod item) : base(item) { }
            public OneOrManyAppliesToDeliveryMethod(IEnumerable<IAppliesToDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (DeliveryMethod value) { return new OneOrManyAppliesToDeliveryMethod (new AppliesToDeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyAppliesToDeliveryMethod (values.Select(v => (IAppliesToDeliveryMethod) new AppliesToDeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyAppliesToDeliveryMethod (values.Select(v => (IAppliesToDeliveryMethod) new AppliesToDeliveryMethodDeliveryMethod (v))); }
        }
        public struct AppliesToDeliveryMethodDeliveryMethod : IAppliesToDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public AppliesToDeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator AppliesToDeliveryMethodDeliveryMethod (DeliveryMethod value) { return new AppliesToDeliveryMethodDeliveryMethod (value); }
        }

        public interface IAppliesToPaymentMethod : IValue {}
        public interface IAppliesToPaymentMethod<T> : IAppliesToPaymentMethod { new T Value { get; } }
        public class OneOrManyAppliesToPaymentMethod : OneOrMany<IAppliesToPaymentMethod>
        {
            public OneOrManyAppliesToPaymentMethod(IAppliesToPaymentMethod item) : base(item) { }
            public OneOrManyAppliesToPaymentMethod(IEnumerable<IAppliesToPaymentMethod> items) : base(items) { }
            public static implicit operator OneOrManyAppliesToPaymentMethod (PaymentMethod value) { return new OneOrManyAppliesToPaymentMethod (new AppliesToPaymentMethodPaymentMethod (value)); }
            public static implicit operator OneOrManyAppliesToPaymentMethod (PaymentMethod[] values) { return new OneOrManyAppliesToPaymentMethod (values.Select(v => (IAppliesToPaymentMethod) new AppliesToPaymentMethodPaymentMethod (v))); }
            public static implicit operator OneOrManyAppliesToPaymentMethod (List<PaymentMethod> values) { return new OneOrManyAppliesToPaymentMethod (values.Select(v => (IAppliesToPaymentMethod) new AppliesToPaymentMethodPaymentMethod (v))); }
        }
        public struct AppliesToPaymentMethodPaymentMethod : IAppliesToPaymentMethod<PaymentMethod>
        {
            object IValue.Value => this.Value;
            public PaymentMethod Value { get; }
            public AppliesToPaymentMethodPaymentMethod (PaymentMethod value) { Value = value; }
            public static implicit operator AppliesToPaymentMethodPaymentMethod (PaymentMethod value) { return new AppliesToPaymentMethodPaymentMethod (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod", Order = 406)]
        public OneOrManyAppliesToDeliveryMethod AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToPaymentMethod", Order = 407)]
        public OneOrManyAppliesToPaymentMethod AppliesToPaymentMethod { get; set; }
    }
}
