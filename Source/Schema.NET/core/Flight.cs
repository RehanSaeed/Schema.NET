namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An airline flight.
    /// </summary>
    [DataContract]
    public partial class Flight : Trip
    {
        public interface IAircraft : IValue {}
        public interface IAircraft<T> : IAircraft { new T Value { get; } }
        public class OneOrManyAircraft : OneOrMany<IAircraft>
        {
            public OneOrManyAircraft(IAircraft item) : base(item) { }
            public OneOrManyAircraft(IEnumerable<IAircraft> items) : base(items) { }
            public static implicit operator OneOrManyAircraft (string value) { return new OneOrManyAircraft (new Aircraftstring (value)); }
            public static implicit operator OneOrManyAircraft (string[] values) { return new OneOrManyAircraft (values.Select(v => (IAircraft) new Aircraftstring (v))); }
            public static implicit operator OneOrManyAircraft (List<string> values) { return new OneOrManyAircraft (values.Select(v => (IAircraft) new Aircraftstring (v))); }
            public static implicit operator OneOrManyAircraft (Vehicle value) { return new OneOrManyAircraft (new AircraftVehicle (value)); }
            public static implicit operator OneOrManyAircraft (Vehicle[] values) { return new OneOrManyAircraft (values.Select(v => (IAircraft) new AircraftVehicle (v))); }
            public static implicit operator OneOrManyAircraft (List<Vehicle> values) { return new OneOrManyAircraft (values.Select(v => (IAircraft) new AircraftVehicle (v))); }
        }
        public struct Aircraftstring : IAircraft<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Aircraftstring (string value) { Value = value; }
            public static implicit operator Aircraftstring (string value) { return new Aircraftstring (value); }
        }
        public struct AircraftVehicle : IAircraft<Vehicle>
        {
            object IValue.Value => this.Value;
            public Vehicle Value { get; }
            public AircraftVehicle (Vehicle value) { Value = value; }
            public static implicit operator AircraftVehicle (Vehicle value) { return new AircraftVehicle (value); }
        }

        public interface IArrivalAirport : IValue {}
        public interface IArrivalAirport<T> : IArrivalAirport { new T Value { get; } }
        public class OneOrManyArrivalAirport : OneOrMany<IArrivalAirport>
        {
            public OneOrManyArrivalAirport(IArrivalAirport item) : base(item) { }
            public OneOrManyArrivalAirport(IEnumerable<IArrivalAirport> items) : base(items) { }
            public static implicit operator OneOrManyArrivalAirport (Airport value) { return new OneOrManyArrivalAirport (new ArrivalAirportAirport (value)); }
            public static implicit operator OneOrManyArrivalAirport (Airport[] values) { return new OneOrManyArrivalAirport (values.Select(v => (IArrivalAirport) new ArrivalAirportAirport (v))); }
            public static implicit operator OneOrManyArrivalAirport (List<Airport> values) { return new OneOrManyArrivalAirport (values.Select(v => (IArrivalAirport) new ArrivalAirportAirport (v))); }
        }
        public struct ArrivalAirportAirport : IArrivalAirport<Airport>
        {
            object IValue.Value => this.Value;
            public Airport Value { get; }
            public ArrivalAirportAirport (Airport value) { Value = value; }
            public static implicit operator ArrivalAirportAirport (Airport value) { return new ArrivalAirportAirport (value); }
        }

        public interface IArrivalGate : IValue {}
        public interface IArrivalGate<T> : IArrivalGate { new T Value { get; } }
        public class OneOrManyArrivalGate : OneOrMany<IArrivalGate>
        {
            public OneOrManyArrivalGate(IArrivalGate item) : base(item) { }
            public OneOrManyArrivalGate(IEnumerable<IArrivalGate> items) : base(items) { }
            public static implicit operator OneOrManyArrivalGate (string value) { return new OneOrManyArrivalGate (new ArrivalGatestring (value)); }
            public static implicit operator OneOrManyArrivalGate (string[] values) { return new OneOrManyArrivalGate (values.Select(v => (IArrivalGate) new ArrivalGatestring (v))); }
            public static implicit operator OneOrManyArrivalGate (List<string> values) { return new OneOrManyArrivalGate (values.Select(v => (IArrivalGate) new ArrivalGatestring (v))); }
        }
        public struct ArrivalGatestring : IArrivalGate<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArrivalGatestring (string value) { Value = value; }
            public static implicit operator ArrivalGatestring (string value) { return new ArrivalGatestring (value); }
        }

        public interface IArrivalTerminal : IValue {}
        public interface IArrivalTerminal<T> : IArrivalTerminal { new T Value { get; } }
        public class OneOrManyArrivalTerminal : OneOrMany<IArrivalTerminal>
        {
            public OneOrManyArrivalTerminal(IArrivalTerminal item) : base(item) { }
            public OneOrManyArrivalTerminal(IEnumerable<IArrivalTerminal> items) : base(items) { }
            public static implicit operator OneOrManyArrivalTerminal (string value) { return new OneOrManyArrivalTerminal (new ArrivalTerminalstring (value)); }
            public static implicit operator OneOrManyArrivalTerminal (string[] values) { return new OneOrManyArrivalTerminal (values.Select(v => (IArrivalTerminal) new ArrivalTerminalstring (v))); }
            public static implicit operator OneOrManyArrivalTerminal (List<string> values) { return new OneOrManyArrivalTerminal (values.Select(v => (IArrivalTerminal) new ArrivalTerminalstring (v))); }
        }
        public struct ArrivalTerminalstring : IArrivalTerminal<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArrivalTerminalstring (string value) { Value = value; }
            public static implicit operator ArrivalTerminalstring (string value) { return new ArrivalTerminalstring (value); }
        }

        public interface IBoardingPolicy : IValue {}
        public interface IBoardingPolicy<T> : IBoardingPolicy { new T Value { get; } }
        public class OneOrManyBoardingPolicy : OneOrMany<IBoardingPolicy>
        {
            public OneOrManyBoardingPolicy(IBoardingPolicy item) : base(item) { }
            public OneOrManyBoardingPolicy(IEnumerable<IBoardingPolicy> items) : base(items) { }
            public static implicit operator OneOrManyBoardingPolicy (BoardingPolicyType value) { return new OneOrManyBoardingPolicy (new BoardingPolicyBoardingPolicyType (value)); }
            public static implicit operator OneOrManyBoardingPolicy (BoardingPolicyType[] values) { return new OneOrManyBoardingPolicy (values.Select(v => (IBoardingPolicy) new BoardingPolicyBoardingPolicyType (v))); }
            public static implicit operator OneOrManyBoardingPolicy (List<BoardingPolicyType> values) { return new OneOrManyBoardingPolicy (values.Select(v => (IBoardingPolicy) new BoardingPolicyBoardingPolicyType (v))); }
        }
        public struct BoardingPolicyBoardingPolicyType : IBoardingPolicy<BoardingPolicyType>
        {
            object IValue.Value => this.Value;
            public BoardingPolicyType Value { get; }
            public BoardingPolicyBoardingPolicyType (BoardingPolicyType value) { Value = value; }
            public static implicit operator BoardingPolicyBoardingPolicyType (BoardingPolicyType value) { return new BoardingPolicyBoardingPolicyType (value); }
        }

        public interface IDepartureAirport : IValue {}
        public interface IDepartureAirport<T> : IDepartureAirport { new T Value { get; } }
        public class OneOrManyDepartureAirport : OneOrMany<IDepartureAirport>
        {
            public OneOrManyDepartureAirport(IDepartureAirport item) : base(item) { }
            public OneOrManyDepartureAirport(IEnumerable<IDepartureAirport> items) : base(items) { }
            public static implicit operator OneOrManyDepartureAirport (Airport value) { return new OneOrManyDepartureAirport (new DepartureAirportAirport (value)); }
            public static implicit operator OneOrManyDepartureAirport (Airport[] values) { return new OneOrManyDepartureAirport (values.Select(v => (IDepartureAirport) new DepartureAirportAirport (v))); }
            public static implicit operator OneOrManyDepartureAirport (List<Airport> values) { return new OneOrManyDepartureAirport (values.Select(v => (IDepartureAirport) new DepartureAirportAirport (v))); }
        }
        public struct DepartureAirportAirport : IDepartureAirport<Airport>
        {
            object IValue.Value => this.Value;
            public Airport Value { get; }
            public DepartureAirportAirport (Airport value) { Value = value; }
            public static implicit operator DepartureAirportAirport (Airport value) { return new DepartureAirportAirport (value); }
        }

        public interface IDepartureGate : IValue {}
        public interface IDepartureGate<T> : IDepartureGate { new T Value { get; } }
        public class OneOrManyDepartureGate : OneOrMany<IDepartureGate>
        {
            public OneOrManyDepartureGate(IDepartureGate item) : base(item) { }
            public OneOrManyDepartureGate(IEnumerable<IDepartureGate> items) : base(items) { }
            public static implicit operator OneOrManyDepartureGate (string value) { return new OneOrManyDepartureGate (new DepartureGatestring (value)); }
            public static implicit operator OneOrManyDepartureGate (string[] values) { return new OneOrManyDepartureGate (values.Select(v => (IDepartureGate) new DepartureGatestring (v))); }
            public static implicit operator OneOrManyDepartureGate (List<string> values) { return new OneOrManyDepartureGate (values.Select(v => (IDepartureGate) new DepartureGatestring (v))); }
        }
        public struct DepartureGatestring : IDepartureGate<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DepartureGatestring (string value) { Value = value; }
            public static implicit operator DepartureGatestring (string value) { return new DepartureGatestring (value); }
        }

        public interface IDepartureTerminal : IValue {}
        public interface IDepartureTerminal<T> : IDepartureTerminal { new T Value { get; } }
        public class OneOrManyDepartureTerminal : OneOrMany<IDepartureTerminal>
        {
            public OneOrManyDepartureTerminal(IDepartureTerminal item) : base(item) { }
            public OneOrManyDepartureTerminal(IEnumerable<IDepartureTerminal> items) : base(items) { }
            public static implicit operator OneOrManyDepartureTerminal (string value) { return new OneOrManyDepartureTerminal (new DepartureTerminalstring (value)); }
            public static implicit operator OneOrManyDepartureTerminal (string[] values) { return new OneOrManyDepartureTerminal (values.Select(v => (IDepartureTerminal) new DepartureTerminalstring (v))); }
            public static implicit operator OneOrManyDepartureTerminal (List<string> values) { return new OneOrManyDepartureTerminal (values.Select(v => (IDepartureTerminal) new DepartureTerminalstring (v))); }
        }
        public struct DepartureTerminalstring : IDepartureTerminal<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DepartureTerminalstring (string value) { Value = value; }
            public static implicit operator DepartureTerminalstring (string value) { return new DepartureTerminalstring (value); }
        }

        public interface IEstimatedFlightDuration : IValue {}
        public interface IEstimatedFlightDuration<T> : IEstimatedFlightDuration { new T Value { get; } }
        public class OneOrManyEstimatedFlightDuration : OneOrMany<IEstimatedFlightDuration>
        {
            public OneOrManyEstimatedFlightDuration(IEstimatedFlightDuration item) : base(item) { }
            public OneOrManyEstimatedFlightDuration(IEnumerable<IEstimatedFlightDuration> items) : base(items) { }
            public static implicit operator OneOrManyEstimatedFlightDuration (TimeSpan value) { return new OneOrManyEstimatedFlightDuration (new EstimatedFlightDurationTimeSpan (value)); }
            public static implicit operator OneOrManyEstimatedFlightDuration (TimeSpan[] values) { return new OneOrManyEstimatedFlightDuration (values.Select(v => (IEstimatedFlightDuration) new EstimatedFlightDurationTimeSpan (v))); }
            public static implicit operator OneOrManyEstimatedFlightDuration (List<TimeSpan> values) { return new OneOrManyEstimatedFlightDuration (values.Select(v => (IEstimatedFlightDuration) new EstimatedFlightDurationTimeSpan (v))); }
            public static implicit operator OneOrManyEstimatedFlightDuration (string value) { return new OneOrManyEstimatedFlightDuration (new EstimatedFlightDurationstring (value)); }
            public static implicit operator OneOrManyEstimatedFlightDuration (string[] values) { return new OneOrManyEstimatedFlightDuration (values.Select(v => (IEstimatedFlightDuration) new EstimatedFlightDurationstring (v))); }
            public static implicit operator OneOrManyEstimatedFlightDuration (List<string> values) { return new OneOrManyEstimatedFlightDuration (values.Select(v => (IEstimatedFlightDuration) new EstimatedFlightDurationstring (v))); }
        }
        public struct EstimatedFlightDurationTimeSpan : IEstimatedFlightDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public EstimatedFlightDurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator EstimatedFlightDurationTimeSpan (TimeSpan value) { return new EstimatedFlightDurationTimeSpan (value); }
        }
        public struct EstimatedFlightDurationstring : IEstimatedFlightDuration<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EstimatedFlightDurationstring (string value) { Value = value; }
            public static implicit operator EstimatedFlightDurationstring (string value) { return new EstimatedFlightDurationstring (value); }
        }

        public interface IFlightDistance : IValue {}
        public interface IFlightDistance<T> : IFlightDistance { new T Value { get; } }
        public class OneOrManyFlightDistance : OneOrMany<IFlightDistance>
        {
            public OneOrManyFlightDistance(IFlightDistance item) : base(item) { }
            public OneOrManyFlightDistance(IEnumerable<IFlightDistance> items) : base(items) { }
            public static implicit operator OneOrManyFlightDistance (string value) { return new OneOrManyFlightDistance (new FlightDistancestring (value)); }
            public static implicit operator OneOrManyFlightDistance (string[] values) { return new OneOrManyFlightDistance (values.Select(v => (IFlightDistance) new FlightDistancestring (v))); }
            public static implicit operator OneOrManyFlightDistance (List<string> values) { return new OneOrManyFlightDistance (values.Select(v => (IFlightDistance) new FlightDistancestring (v))); }
        }
        public struct FlightDistancestring : IFlightDistance<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FlightDistancestring (string value) { Value = value; }
            public static implicit operator FlightDistancestring (string value) { return new FlightDistancestring (value); }
        }

        public interface IFlightNumber : IValue {}
        public interface IFlightNumber<T> : IFlightNumber { new T Value { get; } }
        public class OneOrManyFlightNumber : OneOrMany<IFlightNumber>
        {
            public OneOrManyFlightNumber(IFlightNumber item) : base(item) { }
            public OneOrManyFlightNumber(IEnumerable<IFlightNumber> items) : base(items) { }
            public static implicit operator OneOrManyFlightNumber (string value) { return new OneOrManyFlightNumber (new FlightNumberstring (value)); }
            public static implicit operator OneOrManyFlightNumber (string[] values) { return new OneOrManyFlightNumber (values.Select(v => (IFlightNumber) new FlightNumberstring (v))); }
            public static implicit operator OneOrManyFlightNumber (List<string> values) { return new OneOrManyFlightNumber (values.Select(v => (IFlightNumber) new FlightNumberstring (v))); }
        }
        public struct FlightNumberstring : IFlightNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FlightNumberstring (string value) { Value = value; }
            public static implicit operator FlightNumberstring (string value) { return new FlightNumberstring (value); }
        }

        public interface IMealService : IValue {}
        public interface IMealService<T> : IMealService { new T Value { get; } }
        public class OneOrManyMealService : OneOrMany<IMealService>
        {
            public OneOrManyMealService(IMealService item) : base(item) { }
            public OneOrManyMealService(IEnumerable<IMealService> items) : base(items) { }
            public static implicit operator OneOrManyMealService (string value) { return new OneOrManyMealService (new MealServicestring (value)); }
            public static implicit operator OneOrManyMealService (string[] values) { return new OneOrManyMealService (values.Select(v => (IMealService) new MealServicestring (v))); }
            public static implicit operator OneOrManyMealService (List<string> values) { return new OneOrManyMealService (values.Select(v => (IMealService) new MealServicestring (v))); }
        }
        public struct MealServicestring : IMealService<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MealServicestring (string value) { Value = value; }
            public static implicit operator MealServicestring (string value) { return new MealServicestring (value); }
        }

        public interface ISeller : IValue {}
        public interface ISeller<T> : ISeller { new T Value { get; } }
        public class OneOrManySeller : OneOrMany<ISeller>
        {
            public OneOrManySeller(ISeller item) : base(item) { }
            public OneOrManySeller(IEnumerable<ISeller> items) : base(items) { }
            public static implicit operator OneOrManySeller (Organization value) { return new OneOrManySeller (new SellerOrganization (value)); }
            public static implicit operator OneOrManySeller (Organization[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (List<Organization> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (Person value) { return new OneOrManySeller (new SellerPerson (value)); }
            public static implicit operator OneOrManySeller (Person[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
            public static implicit operator OneOrManySeller (List<Person> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
        }
        public struct SellerOrganization : ISeller<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SellerOrganization (Organization value) { Value = value; }
            public static implicit operator SellerOrganization (Organization value) { return new SellerOrganization (value); }
        }
        public struct SellerPerson : ISeller<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SellerPerson (Person value) { Value = value; }
            public static implicit operator SellerPerson (Person value) { return new SellerPerson (value); }
        }

        public interface IWebCheckinTime : IValue {}
        public interface IWebCheckinTime<T> : IWebCheckinTime { new T Value { get; } }
        public class OneOrManyWebCheckinTime : OneOrMany<IWebCheckinTime>
        {
            public OneOrManyWebCheckinTime(IWebCheckinTime item) : base(item) { }
            public OneOrManyWebCheckinTime(IEnumerable<IWebCheckinTime> items) : base(items) { }
            public static implicit operator OneOrManyWebCheckinTime (DateTimeOffset value) { return new OneOrManyWebCheckinTime (new WebCheckinTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyWebCheckinTime (DateTimeOffset[] values) { return new OneOrManyWebCheckinTime (values.Select(v => (IWebCheckinTime) new WebCheckinTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyWebCheckinTime (List<DateTimeOffset> values) { return new OneOrManyWebCheckinTime (values.Select(v => (IWebCheckinTime) new WebCheckinTimeDateTimeOffset (v))); }
        }
        public struct WebCheckinTimeDateTimeOffset : IWebCheckinTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public WebCheckinTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator WebCheckinTimeDateTimeOffset (DateTimeOffset value) { return new WebCheckinTimeDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [DataMember(Name = "aircraft", Order = 306)]
        public OneOrManyAircraft Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [DataMember(Name = "arrivalAirport", Order = 307)]
        public OneOrManyArrivalAirport ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [DataMember(Name = "arrivalGate", Order = 308)]
        public OneOrManyArrivalGate ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [DataMember(Name = "arrivalTerminal", Order = 309)]
        public OneOrManyArrivalTerminal ArrivalTerminal { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 310)]
        public OneOrManyBoardingPolicy BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [DataMember(Name = "departureAirport", Order = 311)]
        public OneOrManyDepartureAirport DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [DataMember(Name = "departureGate", Order = 312)]
        public OneOrManyDepartureGate DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [DataMember(Name = "departureTerminal", Order = 313)]
        public OneOrManyDepartureTerminal DepartureTerminal { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [DataMember(Name = "estimatedFlightDuration", Order = 314)]
        public OneOrManyEstimatedFlightDuration EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [DataMember(Name = "flightDistance", Order = 315)]
        public OneOrManyFlightDistance FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [DataMember(Name = "flightNumber", Order = 316)]
        public OneOrManyFlightNumber FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [DataMember(Name = "mealService", Order = 317)]
        public OneOrManyMealService MealService { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 318)]
        public OneOrManySeller Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [DataMember(Name = "webCheckinTime", Order = 319)]
        public OneOrManyWebCheckinTime WebCheckinTime { get; set; }
    }
}
