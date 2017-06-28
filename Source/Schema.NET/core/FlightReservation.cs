namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for air travel.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class FlightReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FlightReservation";

        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        [DataMember(Name = "boardingGroup", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [DataMember(Name = "passengerPriorityStatus", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        [DataMember(Name = "passengerSequenceNumber", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        [DataMember(Name = "securityScreening", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SecurityScreening { get; set; }
    }
}
