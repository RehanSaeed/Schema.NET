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
        [DataMember(Name = "@type")]
        public override string Type => "Seat";

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [DataMember(Name = "seatingType")]
        public object SeatingType { get; protected set; }

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [IgnoreDataMember]
        public QualitativeValue SeatingTypeQualitativeValue
        {
            get => this.SeatingType as QualitativeValue;
            set => this.SeatingType = value;
        }

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [IgnoreDataMember]
        public string SeatingTypeText
        {
            get => this.SeatingType as string;
            set => this.SeatingType = value;
        }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection")]
        public string SeatSection { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow")]
        public string SeatRow { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber")]
        public string SeatNumber { get; set; }
    }
}
