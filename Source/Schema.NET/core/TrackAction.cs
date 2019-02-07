namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class TrackAction : FindAction
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
        public override string Type => "TrackAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        public OneOrManyDeliveryMethod DeliveryMethod { get; set; }
    }
}
