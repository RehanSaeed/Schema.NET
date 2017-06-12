namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    [DataContract]
    public class Seat : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Seat";

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [DataMember(Name = "seatingType", Order = 2)]
        public string SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber", Order = 3)]
        public string SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow", Order = 4)]
        public string SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection", Order = 5)]
        public string SeatSection { get; set; }
    }
}
