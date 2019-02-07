namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    [DataContract]
    public partial class ReservationPackage : Reservation
    {
        public interface ISubReservation : IValue {}
        public interface ISubReservation<T> : ISubReservation { new T Value { get; } }
        public class OneOrManySubReservation : OneOrMany<ISubReservation>
        {
            public OneOrManySubReservation(ISubReservation item) : base(item) { }
            public OneOrManySubReservation(IEnumerable<ISubReservation> items) : base(items) { }
            public static implicit operator OneOrManySubReservation (Reservation value) { return new OneOrManySubReservation (new SubReservationReservation (value)); }
            public static implicit operator OneOrManySubReservation (Reservation[] values) { return new OneOrManySubReservation (values.Select(v => (ISubReservation) new SubReservationReservation (v))); }
            public static implicit operator OneOrManySubReservation (List<Reservation> values) { return new OneOrManySubReservation (values.Select(v => (ISubReservation) new SubReservationReservation (v))); }
        }
        public struct SubReservationReservation : ISubReservation<Reservation>
        {
            object IValue.Value => this.Value;
            public Reservation Value { get; }
            public SubReservationReservation (Reservation value) { Value = value; }
            public static implicit operator SubReservationReservation (Reservation value) { return new SubReservationReservation (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReservationPackage";

        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        [DataMember(Name = "subReservation", Order = 306)]
        public OneOrManySubReservation SubReservation { get; set; }
    }
}
