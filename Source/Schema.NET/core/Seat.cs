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
        OneOrMany<string>? SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        OneOrMany<string>? SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        OneOrMany<string>? SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        OneOrMany<string>? SeatSection { get; set; }
    }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    [DataContract]
    public partial class Seat : Intangible, ISeat
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SeatSection { get; set; }
    }
}
