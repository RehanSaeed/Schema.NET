namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial interface IFlightReservation : IReservation
    {
        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        OneOrMany<string>? BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        OneOrMany<string>? PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        OneOrMany<string>? PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        OneOrMany<string>? SecurityScreening { get; set; }
    }

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class FlightReservation : Reservation, IFlightReservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FlightReservation";

        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        [DataMember(Name = "boardingGroup", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [DataMember(Name = "passengerPriorityStatus", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        [DataMember(Name = "passengerSequenceNumber", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        [DataMember(Name = "securityScreening", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SecurityScreening { get; set; }
    }
}
