namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class LodgingReservation : Reservation
    {
        public interface ICheckinTime : IValue {}
        public interface ICheckinTime<T> : ICheckinTime { new T Value { get; } }
        public class OneOrManyCheckinTime : OneOrMany<ICheckinTime>
        {
            public OneOrManyCheckinTime(ICheckinTime item) : base(item) { }
            public OneOrManyCheckinTime(IEnumerable<ICheckinTime> items) : base(items) { }
            public static implicit operator OneOrManyCheckinTime (DateTimeOffset value) { return new OneOrManyCheckinTime (new CheckinTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCheckinTime (DateTimeOffset[] values) { return new OneOrManyCheckinTime (values.Select(v => (ICheckinTime) new CheckinTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCheckinTime (List<DateTimeOffset> values) { return new OneOrManyCheckinTime (values.Select(v => (ICheckinTime) new CheckinTimeDateTimeOffset (v))); }
        }
        public struct CheckinTimeDateTimeOffset : ICheckinTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CheckinTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CheckinTimeDateTimeOffset (DateTimeOffset value) { return new CheckinTimeDateTimeOffset (value); }
        }

        public interface ICheckoutTime : IValue {}
        public interface ICheckoutTime<T> : ICheckoutTime { new T Value { get; } }
        public class OneOrManyCheckoutTime : OneOrMany<ICheckoutTime>
        {
            public OneOrManyCheckoutTime(ICheckoutTime item) : base(item) { }
            public OneOrManyCheckoutTime(IEnumerable<ICheckoutTime> items) : base(items) { }
            public static implicit operator OneOrManyCheckoutTime (DateTimeOffset value) { return new OneOrManyCheckoutTime (new CheckoutTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCheckoutTime (DateTimeOffset[] values) { return new OneOrManyCheckoutTime (values.Select(v => (ICheckoutTime) new CheckoutTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCheckoutTime (List<DateTimeOffset> values) { return new OneOrManyCheckoutTime (values.Select(v => (ICheckoutTime) new CheckoutTimeDateTimeOffset (v))); }
        }
        public struct CheckoutTimeDateTimeOffset : ICheckoutTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CheckoutTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CheckoutTimeDateTimeOffset (DateTimeOffset value) { return new CheckoutTimeDateTimeOffset (value); }
        }

        public interface ILodgingUnitDescription : IValue {}
        public interface ILodgingUnitDescription<T> : ILodgingUnitDescription { new T Value { get; } }
        public class OneOrManyLodgingUnitDescription : OneOrMany<ILodgingUnitDescription>
        {
            public OneOrManyLodgingUnitDescription(ILodgingUnitDescription item) : base(item) { }
            public OneOrManyLodgingUnitDescription(IEnumerable<ILodgingUnitDescription> items) : base(items) { }
            public static implicit operator OneOrManyLodgingUnitDescription (string value) { return new OneOrManyLodgingUnitDescription (new LodgingUnitDescriptionstring (value)); }
            public static implicit operator OneOrManyLodgingUnitDescription (string[] values) { return new OneOrManyLodgingUnitDescription (values.Select(v => (ILodgingUnitDescription) new LodgingUnitDescriptionstring (v))); }
            public static implicit operator OneOrManyLodgingUnitDescription (List<string> values) { return new OneOrManyLodgingUnitDescription (values.Select(v => (ILodgingUnitDescription) new LodgingUnitDescriptionstring (v))); }
        }
        public struct LodgingUnitDescriptionstring : ILodgingUnitDescription<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LodgingUnitDescriptionstring (string value) { Value = value; }
            public static implicit operator LodgingUnitDescriptionstring (string value) { return new LodgingUnitDescriptionstring (value); }
        }

        public interface ILodgingUnitType : IValue {}
        public interface ILodgingUnitType<T> : ILodgingUnitType { new T Value { get; } }
        public class OneOrManyLodgingUnitType : OneOrMany<ILodgingUnitType>
        {
            public OneOrManyLodgingUnitType(ILodgingUnitType item) : base(item) { }
            public OneOrManyLodgingUnitType(IEnumerable<ILodgingUnitType> items) : base(items) { }
            public static implicit operator OneOrManyLodgingUnitType (string value) { return new OneOrManyLodgingUnitType (new LodgingUnitTypestring (value)); }
            public static implicit operator OneOrManyLodgingUnitType (string[] values) { return new OneOrManyLodgingUnitType (values.Select(v => (ILodgingUnitType) new LodgingUnitTypestring (v))); }
            public static implicit operator OneOrManyLodgingUnitType (List<string> values) { return new OneOrManyLodgingUnitType (values.Select(v => (ILodgingUnitType) new LodgingUnitTypestring (v))); }
        }
        public struct LodgingUnitTypestring : ILodgingUnitType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LodgingUnitTypestring (string value) { Value = value; }
            public static implicit operator LodgingUnitTypestring (string value) { return new LodgingUnitTypestring (value); }
        }

        public interface INumAdults : IValue {}
        public interface INumAdults<T> : INumAdults { new T Value { get; } }
        public class OneOrManyNumAdults : OneOrMany<INumAdults>
        {
            public OneOrManyNumAdults(INumAdults item) : base(item) { }
            public OneOrManyNumAdults(IEnumerable<INumAdults> items) : base(items) { }
            public static implicit operator OneOrManyNumAdults (int value) { return new OneOrManyNumAdults (new NumAdultsint (value)); }
            public static implicit operator OneOrManyNumAdults (int[] values) { return new OneOrManyNumAdults (values.Select(v => (INumAdults) new NumAdultsint (v))); }
            public static implicit operator OneOrManyNumAdults (List<int> values) { return new OneOrManyNumAdults (values.Select(v => (INumAdults) new NumAdultsint (v))); }
            public static implicit operator OneOrManyNumAdults (QuantitativeValue value) { return new OneOrManyNumAdults (new NumAdultsQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumAdults (QuantitativeValue[] values) { return new OneOrManyNumAdults (values.Select(v => (INumAdults) new NumAdultsQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumAdults (List<QuantitativeValue> values) { return new OneOrManyNumAdults (values.Select(v => (INumAdults) new NumAdultsQuantitativeValue (v))); }
        }
        public struct NumAdultsint : INumAdults<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumAdultsint (int value) { Value = value; }
            public static implicit operator NumAdultsint (int value) { return new NumAdultsint (value); }
        }
        public struct NumAdultsQuantitativeValue : INumAdults<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumAdultsQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumAdultsQuantitativeValue (QuantitativeValue value) { return new NumAdultsQuantitativeValue (value); }
        }

        public interface INumChildren : IValue {}
        public interface INumChildren<T> : INumChildren { new T Value { get; } }
        public class OneOrManyNumChildren : OneOrMany<INumChildren>
        {
            public OneOrManyNumChildren(INumChildren item) : base(item) { }
            public OneOrManyNumChildren(IEnumerable<INumChildren> items) : base(items) { }
            public static implicit operator OneOrManyNumChildren (int value) { return new OneOrManyNumChildren (new NumChildrenint (value)); }
            public static implicit operator OneOrManyNumChildren (int[] values) { return new OneOrManyNumChildren (values.Select(v => (INumChildren) new NumChildrenint (v))); }
            public static implicit operator OneOrManyNumChildren (List<int> values) { return new OneOrManyNumChildren (values.Select(v => (INumChildren) new NumChildrenint (v))); }
            public static implicit operator OneOrManyNumChildren (QuantitativeValue value) { return new OneOrManyNumChildren (new NumChildrenQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumChildren (QuantitativeValue[] values) { return new OneOrManyNumChildren (values.Select(v => (INumChildren) new NumChildrenQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumChildren (List<QuantitativeValue> values) { return new OneOrManyNumChildren (values.Select(v => (INumChildren) new NumChildrenQuantitativeValue (v))); }
        }
        public struct NumChildrenint : INumChildren<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumChildrenint (int value) { Value = value; }
            public static implicit operator NumChildrenint (int value) { return new NumChildrenint (value); }
        }
        public struct NumChildrenQuantitativeValue : INumChildren<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumChildrenQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumChildrenQuantitativeValue (QuantitativeValue value) { return new NumChildrenQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 306)]
        public OneOrManyCheckinTime CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 307)]
        public OneOrManyCheckoutTime CheckoutTime { get; set; }

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription", Order = 308)]
        public OneOrManyLodgingUnitDescription LodgingUnitDescription { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType", Order = 309)]
        public OneOrManyLodgingUnitType LodgingUnitType { get; set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults", Order = 310)]
        public OneOrManyNumAdults NumAdults { get; set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren", Order = 311)]
        public OneOrManyNumChildren NumChildren { get; set; }
    }
}
