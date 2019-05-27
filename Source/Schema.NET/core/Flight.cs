namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An airline flight.
    /// </summary>
    public partial interface IFlight : ITrip
    {
        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        Values<string, IVehicle>? Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        OneOrMany<IAirport> ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        OneOrMany<string> ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        OneOrMany<string> ArrivalTerminal { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        OneOrMany<IAirport> DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        OneOrMany<string> DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        OneOrMany<string> DepartureTerminal { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        Values<TimeSpan?, string>? EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        Values<string, string>? FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        OneOrMany<string> FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        OneOrMany<string> MealService { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        Values<IOrganization, IPerson>? Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        OneOrMany<DateTimeOffset?> WebCheckinTime { get; set; }
    }

    /// <summary>
    /// An airline flight.
    /// </summary>
    [DataContract]
    public partial class Flight : Trip, IFlight
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [DataMember(Name = "aircraft", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IVehicle>? Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [DataMember(Name = "arrivalAirport", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAirport> ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [DataMember(Name = "arrivalGate", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [DataMember(Name = "arrivalTerminal", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArrivalTerminal { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [DataMember(Name = "departureAirport", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAirport> DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [DataMember(Name = "departureGate", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [DataMember(Name = "departureTerminal", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DepartureTerminal { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [DataMember(Name = "estimatedFlightDuration", Order = 314)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public Values<TimeSpan?, string>? EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [DataMember(Name = "flightDistance", Order = 315)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, string>? FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [DataMember(Name = "flightNumber", Order = 316)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [DataMember(Name = "mealService", Order = 317)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MealService { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 318)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson>? Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [DataMember(Name = "webCheckinTime", Order = 319)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> WebCheckinTime { get; set; }
    }
}
