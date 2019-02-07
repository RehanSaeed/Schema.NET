namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    [DataContract]
    public partial class Seat : Intangible
    {
        public interface ISeatingType : IValue {}
        public interface ISeatingType<T> : ISeatingType { new T Value { get; } }
        public class OneOrManySeatingType : OneOrMany<ISeatingType>
        {
            public OneOrManySeatingType(ISeatingType item) : base(item) { }
            public OneOrManySeatingType(IEnumerable<ISeatingType> items) : base(items) { }
            public static implicit operator OneOrManySeatingType (string value) { return new OneOrManySeatingType (new SeatingTypestring (value)); }
            public static implicit operator OneOrManySeatingType (string[] values) { return new OneOrManySeatingType (values.Select(v => (ISeatingType) new SeatingTypestring (v))); }
            public static implicit operator OneOrManySeatingType (List<string> values) { return new OneOrManySeatingType (values.Select(v => (ISeatingType) new SeatingTypestring (v))); }
        }
        public struct SeatingTypestring : ISeatingType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SeatingTypestring (string value) { Value = value; }
            public static implicit operator SeatingTypestring (string value) { return new SeatingTypestring (value); }
        }

        public interface ISeatNumber : IValue {}
        public interface ISeatNumber<T> : ISeatNumber { new T Value { get; } }
        public class OneOrManySeatNumber : OneOrMany<ISeatNumber>
        {
            public OneOrManySeatNumber(ISeatNumber item) : base(item) { }
            public OneOrManySeatNumber(IEnumerable<ISeatNumber> items) : base(items) { }
            public static implicit operator OneOrManySeatNumber (string value) { return new OneOrManySeatNumber (new SeatNumberstring (value)); }
            public static implicit operator OneOrManySeatNumber (string[] values) { return new OneOrManySeatNumber (values.Select(v => (ISeatNumber) new SeatNumberstring (v))); }
            public static implicit operator OneOrManySeatNumber (List<string> values) { return new OneOrManySeatNumber (values.Select(v => (ISeatNumber) new SeatNumberstring (v))); }
        }
        public struct SeatNumberstring : ISeatNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SeatNumberstring (string value) { Value = value; }
            public static implicit operator SeatNumberstring (string value) { return new SeatNumberstring (value); }
        }

        public interface ISeatRow : IValue {}
        public interface ISeatRow<T> : ISeatRow { new T Value { get; } }
        public class OneOrManySeatRow : OneOrMany<ISeatRow>
        {
            public OneOrManySeatRow(ISeatRow item) : base(item) { }
            public OneOrManySeatRow(IEnumerable<ISeatRow> items) : base(items) { }
            public static implicit operator OneOrManySeatRow (string value) { return new OneOrManySeatRow (new SeatRowstring (value)); }
            public static implicit operator OneOrManySeatRow (string[] values) { return new OneOrManySeatRow (values.Select(v => (ISeatRow) new SeatRowstring (v))); }
            public static implicit operator OneOrManySeatRow (List<string> values) { return new OneOrManySeatRow (values.Select(v => (ISeatRow) new SeatRowstring (v))); }
        }
        public struct SeatRowstring : ISeatRow<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SeatRowstring (string value) { Value = value; }
            public static implicit operator SeatRowstring (string value) { return new SeatRowstring (value); }
        }

        public interface ISeatSection : IValue {}
        public interface ISeatSection<T> : ISeatSection { new T Value { get; } }
        public class OneOrManySeatSection : OneOrMany<ISeatSection>
        {
            public OneOrManySeatSection(ISeatSection item) : base(item) { }
            public OneOrManySeatSection(IEnumerable<ISeatSection> items) : base(items) { }
            public static implicit operator OneOrManySeatSection (string value) { return new OneOrManySeatSection (new SeatSectionstring (value)); }
            public static implicit operator OneOrManySeatSection (string[] values) { return new OneOrManySeatSection (values.Select(v => (ISeatSection) new SeatSectionstring (v))); }
            public static implicit operator OneOrManySeatSection (List<string> values) { return new OneOrManySeatSection (values.Select(v => (ISeatSection) new SeatSectionstring (v))); }
        }
        public struct SeatSectionstring : ISeatSection<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SeatSectionstring (string value) { Value = value; }
            public static implicit operator SeatSectionstring (string value) { return new SeatSectionstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Seat";

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [DataMember(Name = "seatingType", Order = 206)]
        public OneOrManySeatingType SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber", Order = 207)]
        public OneOrManySeatNumber SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow", Order = 208)]
        public OneOrManySeatRow SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection", Order = 209)]
        public OneOrManySeatSection SeatSection { get; set; }
    }
}
