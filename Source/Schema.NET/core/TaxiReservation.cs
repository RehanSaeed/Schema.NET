namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TaxiReservation : Reservation
    {
        public interface IPartySize : IValue {}
        public interface IPartySize<T> : IPartySize { new T Value { get; } }
        public class OneOrManyPartySize : OneOrMany<IPartySize>
        {
            public OneOrManyPartySize(IPartySize item) : base(item) { }
            public OneOrManyPartySize(IEnumerable<IPartySize> items) : base(items) { }
            public static implicit operator OneOrManyPartySize (int value) { return new OneOrManyPartySize (new PartySizeint (value)); }
            public static implicit operator OneOrManyPartySize (int[] values) { return new OneOrManyPartySize (values.Select(v => (IPartySize) new PartySizeint (v))); }
            public static implicit operator OneOrManyPartySize (List<int> values) { return new OneOrManyPartySize (values.Select(v => (IPartySize) new PartySizeint (v))); }
            public static implicit operator OneOrManyPartySize (QuantitativeValue value) { return new OneOrManyPartySize (new PartySizeQuantitativeValue (value)); }
            public static implicit operator OneOrManyPartySize (QuantitativeValue[] values) { return new OneOrManyPartySize (values.Select(v => (IPartySize) new PartySizeQuantitativeValue (v))); }
            public static implicit operator OneOrManyPartySize (List<QuantitativeValue> values) { return new OneOrManyPartySize (values.Select(v => (IPartySize) new PartySizeQuantitativeValue (v))); }
        }
        public struct PartySizeint : IPartySize<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PartySizeint (int value) { Value = value; }
            public static implicit operator PartySizeint (int value) { return new PartySizeint (value); }
        }
        public struct PartySizeQuantitativeValue : IPartySize<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public PartySizeQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator PartySizeQuantitativeValue (QuantitativeValue value) { return new PartySizeQuantitativeValue (value); }
        }

        public interface IPickupLocation : IValue {}
        public interface IPickupLocation<T> : IPickupLocation { new T Value { get; } }
        public class OneOrManyPickupLocation : OneOrMany<IPickupLocation>
        {
            public OneOrManyPickupLocation(IPickupLocation item) : base(item) { }
            public OneOrManyPickupLocation(IEnumerable<IPickupLocation> items) : base(items) { }
            public static implicit operator OneOrManyPickupLocation (Place value) { return new OneOrManyPickupLocation (new PickupLocationPlace (value)); }
            public static implicit operator OneOrManyPickupLocation (Place[] values) { return new OneOrManyPickupLocation (values.Select(v => (IPickupLocation) new PickupLocationPlace (v))); }
            public static implicit operator OneOrManyPickupLocation (List<Place> values) { return new OneOrManyPickupLocation (values.Select(v => (IPickupLocation) new PickupLocationPlace (v))); }
        }
        public struct PickupLocationPlace : IPickupLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public PickupLocationPlace (Place value) { Value = value; }
            public static implicit operator PickupLocationPlace (Place value) { return new PickupLocationPlace (value); }
        }

        public interface IPickupTime : IValue {}
        public interface IPickupTime<T> : IPickupTime { new T Value { get; } }
        public class OneOrManyPickupTime : OneOrMany<IPickupTime>
        {
            public OneOrManyPickupTime(IPickupTime item) : base(item) { }
            public OneOrManyPickupTime(IEnumerable<IPickupTime> items) : base(items) { }
            public static implicit operator OneOrManyPickupTime (DateTimeOffset value) { return new OneOrManyPickupTime (new PickupTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyPickupTime (DateTimeOffset[] values) { return new OneOrManyPickupTime (values.Select(v => (IPickupTime) new PickupTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyPickupTime (List<DateTimeOffset> values) { return new OneOrManyPickupTime (values.Select(v => (IPickupTime) new PickupTimeDateTimeOffset (v))); }
        }
        public struct PickupTimeDateTimeOffset : IPickupTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public PickupTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator PickupTimeDateTimeOffset (DateTimeOffset value) { return new PickupTimeDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiReservation";

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 306)]
        public OneOrManyPartySize PartySize { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 307)]
        public OneOrManyPickupLocation PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 308)]
        public OneOrManyPickupTime PickupTime { get; set; }
    }
}
