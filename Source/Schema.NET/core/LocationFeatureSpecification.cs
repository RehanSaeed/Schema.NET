namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    [DataContract]
    public partial class LocationFeatureSpecification : PropertyValue
    {
        public interface IHoursAvailable : IValue {}
        public interface IHoursAvailable<T> : IHoursAvailable { new T Value { get; } }
        public class OneOrManyHoursAvailable : OneOrMany<IHoursAvailable>
        {
            public OneOrManyHoursAvailable(IHoursAvailable item) : base(item) { }
            public OneOrManyHoursAvailable(IEnumerable<IHoursAvailable> items) : base(items) { }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification value) { return new OneOrManyHoursAvailable (new HoursAvailableOpeningHoursSpecification (value)); }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification[] values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
            public static implicit operator OneOrManyHoursAvailable (List<OpeningHoursSpecification> values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
        }
        public struct HoursAvailableOpeningHoursSpecification : IHoursAvailable<OpeningHoursSpecification>
        {
            object IValue.Value => this.Value;
            public OpeningHoursSpecification Value { get; }
            public HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { Value = value; }
            public static implicit operator HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { return new HoursAvailableOpeningHoursSpecification (value); }
        }

        public interface IValidFrom : IValue {}
        public interface IValidFrom<T> : IValidFrom { new T Value { get; } }
        public class OneOrManyValidFrom : OneOrMany<IValidFrom>
        {
            public OneOrManyValidFrom(IValidFrom item) : base(item) { }
            public OneOrManyValidFrom(IEnumerable<IValidFrom> items) : base(items) { }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset value) { return new OneOrManyValidFrom (new ValidFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset[] values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidFrom (List<DateTimeOffset> values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
        }
        public struct ValidFromDateTimeOffset : IValidFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidFromDateTimeOffset (DateTimeOffset value) { return new ValidFromDateTimeOffset (value); }
        }

        public interface IValidThrough : IValue {}
        public interface IValidThrough<T> : IValidThrough { new T Value { get; } }
        public class OneOrManyValidThrough : OneOrMany<IValidThrough>
        {
            public OneOrManyValidThrough(IValidThrough item) : base(item) { }
            public OneOrManyValidThrough(IEnumerable<IValidThrough> items) : base(items) { }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset value) { return new OneOrManyValidThrough (new ValidThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset[] values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidThrough (List<DateTimeOffset> values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
        }
        public struct ValidThroughDateTimeOffset : IValidThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidThroughDateTimeOffset (DateTimeOffset value) { return new ValidThroughDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocationFeatureSpecification";

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 406)]
        public OneOrManyHoursAvailable HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 407)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 408)]
        public OneOrManyValidThrough ValidThrough { get; set; }
    }
}
