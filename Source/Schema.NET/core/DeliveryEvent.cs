namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    [DataContract]
    public partial class DeliveryEvent : Event
    {
        public interface IAccessCode : IValue {}
        public interface IAccessCode<T> : IAccessCode { new T Value { get; } }
        public class OneOrManyAccessCode : OneOrMany<IAccessCode>
        {
            public OneOrManyAccessCode(IAccessCode item) : base(item) { }
            public OneOrManyAccessCode(IEnumerable<IAccessCode> items) : base(items) { }
            public static implicit operator OneOrManyAccessCode (string value) { return new OneOrManyAccessCode (new AccessCodestring (value)); }
            public static implicit operator OneOrManyAccessCode (string[] values) { return new OneOrManyAccessCode (values.Select(v => (IAccessCode) new AccessCodestring (v))); }
            public static implicit operator OneOrManyAccessCode (List<string> values) { return new OneOrManyAccessCode (values.Select(v => (IAccessCode) new AccessCodestring (v))); }
        }
        public struct AccessCodestring : IAccessCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessCodestring (string value) { Value = value; }
            public static implicit operator AccessCodestring (string value) { return new AccessCodestring (value); }
        }

        public interface IAvailableFrom : IValue {}
        public interface IAvailableFrom<T> : IAvailableFrom { new T Value { get; } }
        public class OneOrManyAvailableFrom : OneOrMany<IAvailableFrom>
        {
            public OneOrManyAvailableFrom(IAvailableFrom item) : base(item) { }
            public OneOrManyAvailableFrom(IEnumerable<IAvailableFrom> items) : base(items) { }
            public static implicit operator OneOrManyAvailableFrom (DateTimeOffset value) { return new OneOrManyAvailableFrom (new AvailableFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyAvailableFrom (DateTimeOffset[] values) { return new OneOrManyAvailableFrom (values.Select(v => (IAvailableFrom) new AvailableFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyAvailableFrom (List<DateTimeOffset> values) { return new OneOrManyAvailableFrom (values.Select(v => (IAvailableFrom) new AvailableFromDateTimeOffset (v))); }
        }
        public struct AvailableFromDateTimeOffset : IAvailableFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public AvailableFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator AvailableFromDateTimeOffset (DateTimeOffset value) { return new AvailableFromDateTimeOffset (value); }
        }

        public interface IAvailableThrough : IValue {}
        public interface IAvailableThrough<T> : IAvailableThrough { new T Value { get; } }
        public class OneOrManyAvailableThrough : OneOrMany<IAvailableThrough>
        {
            public OneOrManyAvailableThrough(IAvailableThrough item) : base(item) { }
            public OneOrManyAvailableThrough(IEnumerable<IAvailableThrough> items) : base(items) { }
            public static implicit operator OneOrManyAvailableThrough (DateTimeOffset value) { return new OneOrManyAvailableThrough (new AvailableThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyAvailableThrough (DateTimeOffset[] values) { return new OneOrManyAvailableThrough (values.Select(v => (IAvailableThrough) new AvailableThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyAvailableThrough (List<DateTimeOffset> values) { return new OneOrManyAvailableThrough (values.Select(v => (IAvailableThrough) new AvailableThroughDateTimeOffset (v))); }
        }
        public struct AvailableThroughDateTimeOffset : IAvailableThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public AvailableThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator AvailableThroughDateTimeOffset (DateTimeOffset value) { return new AvailableThroughDateTimeOffset (value); }
        }

        public interface IHasDeliveryMethod : IValue {}
        public interface IHasDeliveryMethod<T> : IHasDeliveryMethod { new T Value { get; } }
        public class OneOrManyHasDeliveryMethod : OneOrMany<IHasDeliveryMethod>
        {
            public OneOrManyHasDeliveryMethod(IHasDeliveryMethod item) : base(item) { }
            public OneOrManyHasDeliveryMethod(IEnumerable<IHasDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyHasDeliveryMethod (DeliveryMethod value) { return new OneOrManyHasDeliveryMethod (new HasDeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyHasDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyHasDeliveryMethod (values.Select(v => (IHasDeliveryMethod) new HasDeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyHasDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyHasDeliveryMethod (values.Select(v => (IHasDeliveryMethod) new HasDeliveryMethodDeliveryMethod (v))); }
        }
        public struct HasDeliveryMethodDeliveryMethod : IHasDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public HasDeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator HasDeliveryMethodDeliveryMethod (DeliveryMethod value) { return new HasDeliveryMethodDeliveryMethod (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeliveryEvent";

        /// <summary>
        /// Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        [DataMember(Name = "accessCode", Order = 206)]
        public OneOrManyAccessCode AccessCode { get; set; }

        /// <summary>
        /// When the item is available for pickup from the store, locker, etc.
        /// </summary>
        [DataMember(Name = "availableFrom", Order = 207)]
        public OneOrManyAvailableFrom AvailableFrom { get; set; }

        /// <summary>
        /// After this date, the item will no longer be available for pickup.
        /// </summary>
        [DataMember(Name = "availableThrough", Order = 208)]
        public OneOrManyAvailableThrough AvailableThrough { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 209)]
        public OneOrManyHasDeliveryMethod HasDeliveryMethod { get; set; }
    }
}
