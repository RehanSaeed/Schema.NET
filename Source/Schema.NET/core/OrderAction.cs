namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public partial class OrderAction : TradeAction
    {
        public interface IDeliveryMethod : IValue {}
        public interface IDeliveryMethod<T> : IDeliveryMethod { new T Value { get; } }
        public class OneOrManyDeliveryMethod : OneOrMany<IDeliveryMethod>
        {
            public OneOrManyDeliveryMethod(IDeliveryMethod item) : base(item) { }
            public OneOrManyDeliveryMethod(IEnumerable<IDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod value) { return new OneOrManyDeliveryMethod (new DeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyDeliveryMethod (values.Select(v => (IDeliveryMethod) new DeliveryMethodDeliveryMethod (v))); }
        }
        public struct DeliveryMethodDeliveryMethod : IDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public DeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator DeliveryMethodDeliveryMethod (DeliveryMethod value) { return new DeliveryMethodDeliveryMethod (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        public OneOrManyDeliveryMethod DeliveryMethod { get; set; }
    }
}
