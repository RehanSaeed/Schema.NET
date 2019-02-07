namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class RentalCarReservation : Reservation
    {
        public interface IDropoffLocation : IValue {}
        public interface IDropoffLocation<T> : IDropoffLocation { new T Value { get; } }
        public class OneOrManyDropoffLocation : OneOrMany<IDropoffLocation>
        {
            public OneOrManyDropoffLocation(IDropoffLocation item) : base(item) { }
            public OneOrManyDropoffLocation(IEnumerable<IDropoffLocation> items) : base(items) { }
            public static implicit operator OneOrManyDropoffLocation (Place value) { return new OneOrManyDropoffLocation (new DropoffLocationPlace (value)); }
            public static implicit operator OneOrManyDropoffLocation (Place[] values) { return new OneOrManyDropoffLocation (values.Select(v => (IDropoffLocation) new DropoffLocationPlace (v))); }
            public static implicit operator OneOrManyDropoffLocation (List<Place> values) { return new OneOrManyDropoffLocation (values.Select(v => (IDropoffLocation) new DropoffLocationPlace (v))); }
        }
        public struct DropoffLocationPlace : IDropoffLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public DropoffLocationPlace (Place value) { Value = value; }
            public static implicit operator DropoffLocationPlace (Place value) { return new DropoffLocationPlace (value); }
        }

        public interface IDropoffTime : IValue {}
        public interface IDropoffTime<T> : IDropoffTime { new T Value { get; } }
        public class OneOrManyDropoffTime : OneOrMany<IDropoffTime>
        {
            public OneOrManyDropoffTime(IDropoffTime item) : base(item) { }
            public OneOrManyDropoffTime(IEnumerable<IDropoffTime> items) : base(items) { }
            public static implicit operator OneOrManyDropoffTime (DateTimeOffset value) { return new OneOrManyDropoffTime (new DropoffTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyDropoffTime (DateTimeOffset[] values) { return new OneOrManyDropoffTime (values.Select(v => (IDropoffTime) new DropoffTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyDropoffTime (List<DateTimeOffset> values) { return new OneOrManyDropoffTime (values.Select(v => (IDropoffTime) new DropoffTimeDateTimeOffset (v))); }
        }
        public struct DropoffTimeDateTimeOffset : IDropoffTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DropoffTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DropoffTimeDateTimeOffset (DateTimeOffset value) { return new DropoffTimeDateTimeOffset (value); }
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
        public override string Type => "RentalCarReservation";

        /// <summary>
        /// Where a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffLocation", Order = 306)]
        public OneOrManyDropoffLocation DropoffLocation { get; set; }

        /// <summary>
        /// When a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffTime", Order = 307)]
        public OneOrManyDropoffTime DropoffTime { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 308)]
        public OneOrManyPickupLocation PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 309)]
        public OneOrManyPickupTime PickupTime { get; set; }
    }
}
