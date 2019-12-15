namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    public partial interface ISeat : IIntangible
    {
        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        OneOrMany<string> SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        OneOrMany<string> SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        OneOrMany<string> SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        OneOrMany<string> SeatSection { get; set; }
    }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    [DataContract]
    public partial class Seat : Intangible, ISeat, IEquatable<Seat>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Seat";

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [DataMember(Name = "seatingType", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatSection { get; set; }

        /// <inheritdoc/>
        public bool Equals(Seat other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.SeatingType == other.SeatingType &&
                this.SeatNumber == other.SeatNumber &&
                this.SeatRow == other.SeatRow &&
                this.SeatSection == other.SeatSection &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Seat);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.SeatingType)
            .And(this.SeatNumber)
            .And(this.SeatRow)
            .And(this.SeatSection)
            .And(base.GetHashCode());
    }
}
