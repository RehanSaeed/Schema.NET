namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An airline flight.
    /// </summary>
    [DataContract]
    public partial class Flight : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [DataMember(Name = "aircraft", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Vehicle, string>? Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [DataMember(Name = "arrivalAirport", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Airport>? ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [DataMember(Name = "arrivalGate", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [DataMember(Name = "arrivalTerminal", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalTerminal { get; set; }

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ArrivalTime { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BoardingPolicyType?>? BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [DataMember(Name = "departureAirport", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Airport>? DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [DataMember(Name = "departureGate", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [DataMember(Name = "departureTerminal", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DepartureTerminal { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DepartureTime { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [DataMember(Name = "estimatedFlightDuration", Order = 215)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<string, TimeSpan?>? EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [DataMember(Name = "flightDistance", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [DataMember(Name = "flightNumber", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [DataMember(Name = "mealService", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MealService { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [DataMember(Name = "webCheckinTime", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? WebCheckinTime { get; set; }
    }
}
