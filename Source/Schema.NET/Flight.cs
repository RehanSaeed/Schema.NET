namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An airline flight.
    /// </summary>
    [DataContract]
    public class Flight : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [DataMember(Name = "aircraft", Order = 2)]
        public object Aircraft { get; protected set; }

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [IgnoreDataMember]
        public Vehicle AircraftVehicle
        {
            get => this.Aircraft as Vehicle;
            set => this.Aircraft = value;
        }

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [IgnoreDataMember]
        public string AircraftText
        {
            get => this.Aircraft as string;
            set => this.Aircraft = value;
        }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [DataMember(Name = "arrivalAirport", Order = 3)]
        public Airport ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [DataMember(Name = "arrivalGate", Order = 4)]
        public string ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [DataMember(Name = "arrivalTerminal", Order = 5)]
        public string ArrivalTerminal { get; set; }

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 6)]
        public DateTimeOffset? ArrivalTime { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 7)]
        public BoardingPolicyType? BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [DataMember(Name = "departureAirport", Order = 8)]
        public Airport DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [DataMember(Name = "departureGate", Order = 9)]
        public string DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [DataMember(Name = "departureTerminal", Order = 10)]
        public string DepartureTerminal { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 11)]
        public DateTimeOffset? DepartureTime { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [DataMember(Name = "estimatedFlightDuration", Order = 12)]
        public object EstimatedFlightDuration { get; protected set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [IgnoreDataMember]
        public string EstimatedFlightDurationText
        {
            get => this.EstimatedFlightDuration as string;
            set => this.EstimatedFlightDuration = value;
        }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [IgnoreDataMember]
        public Duration EstimatedFlightDurationDuration
        {
            get => this.EstimatedFlightDuration as Duration;
            set => this.EstimatedFlightDuration = value;
        }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [DataMember(Name = "flightDistance", Order = 13)]
        public object FlightDistance { get; protected set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [IgnoreDataMember]
        public Distance FlightDistanceDistance
        {
            get => this.FlightDistance as Distance;
            set => this.FlightDistance = value;
        }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [IgnoreDataMember]
        public string FlightDistanceText
        {
            get => this.FlightDistance as string;
            set => this.FlightDistance = value;
        }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [DataMember(Name = "flightNumber", Order = 14)]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [DataMember(Name = "mealService", Order = 15)]
        public string MealService { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 16)]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 17)]
        public object Seller { get; protected set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Organization SellerOrganization
        {
            get => this.Seller as Organization;
            set => this.Seller = value;
        }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Person SellerPerson
        {
            get => this.Seller as Person;
            set => this.Seller = value;
        }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [DataMember(Name = "webCheckinTime", Order = 18)]
        public DateTimeOffset? WebCheckinTime { get; set; }
    }
}
