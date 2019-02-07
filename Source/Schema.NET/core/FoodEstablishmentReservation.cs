namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishmentReservation : Reservation
    {
        public interface IEndTime : IValue {}
        public interface IEndTime<T> : IEndTime { new T Value { get; } }
        public class OneOrManyEndTime : OneOrMany<IEndTime>
        {
            public OneOrManyEndTime(IEndTime item) : base(item) { }
            public OneOrManyEndTime(IEnumerable<IEndTime> items) : base(items) { }
            public static implicit operator OneOrManyEndTime (DateTimeOffset value) { return new OneOrManyEndTime (new EndTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndTime (DateTimeOffset[] values) { return new OneOrManyEndTime (values.Select(v => (IEndTime) new EndTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndTime (List<DateTimeOffset> values) { return new OneOrManyEndTime (values.Select(v => (IEndTime) new EndTimeDateTimeOffset (v))); }
        }
        public struct EndTimeDateTimeOffset : IEndTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndTimeDateTimeOffset (DateTimeOffset value) { return new EndTimeDateTimeOffset (value); }
        }

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

        public interface IStartTime : IValue {}
        public interface IStartTime<T> : IStartTime { new T Value { get; } }
        public class OneOrManyStartTime : OneOrMany<IStartTime>
        {
            public OneOrManyStartTime(IStartTime item) : base(item) { }
            public OneOrManyStartTime(IEnumerable<IStartTime> items) : base(items) { }
            public static implicit operator OneOrManyStartTime (DateTimeOffset value) { return new OneOrManyStartTime (new StartTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartTime (DateTimeOffset[] values) { return new OneOrManyStartTime (values.Select(v => (IStartTime) new StartTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartTime (List<DateTimeOffset> values) { return new OneOrManyStartTime (values.Select(v => (IStartTime) new StartTimeDateTimeOffset (v))); }
        }
        public struct StartTimeDateTimeOffset : IStartTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartTimeDateTimeOffset (DateTimeOffset value) { return new StartTimeDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishmentReservation";

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 306)]
        public OneOrManyEndTime EndTime { get; set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 307)]
        public OneOrManyPartySize PartySize { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 308)]
        public OneOrManyStartTime StartTime { get; set; }
    }
}
