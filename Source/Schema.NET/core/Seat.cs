using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    [DataContract]
    public partial class Seat : Intangible
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
        public Values<string>? SeatingType { get; set; } 

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [DataMember(Name = "seatNumber", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SeatNumber { get; set; } 

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [DataMember(Name = "seatRow", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SeatRow { get; set; } 

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [DataMember(Name = "seatSection", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SeatSection { get; set; } 
    }
}
