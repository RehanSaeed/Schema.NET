using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An airline flight.
    /// </summary>
    [DataContract]
    public partial class Flight : Intangible
    {
        public interface IAircraft : IWrapper { }
        public interface IAircraft<T> : IAircraft { new T Data { get; set; } }
        public class Aircraftstring : IAircraft<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Aircraftstring () { }
            public Aircraftstring (string data) { Data = data; }
            public static implicit operator Aircraftstring (string data) { return new Aircraftstring (data); }
        }

        public class AircraftVehicle : IAircraft<Vehicle>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Vehicle) value; } }
            public virtual Vehicle Data { get; set; }
            public AircraftVehicle () { }
            public AircraftVehicle (Vehicle data) { Data = data; }
            public static implicit operator AircraftVehicle (Vehicle data) { return new AircraftVehicle (data); }
        }


        public interface IEstimatedFlightDuration : IWrapper { }
        public interface IEstimatedFlightDuration<T> : IEstimatedFlightDuration { new T Data { get; set; } }
        public class EstimatedFlightDurationTimeSpan : IEstimatedFlightDuration<TimeSpan>
        {
            object IWrapper.Data { get { return Data; } set { Data = (TimeSpan) value; } }
            public virtual TimeSpan Data { get; set; }
            public EstimatedFlightDurationTimeSpan () { }
            public EstimatedFlightDurationTimeSpan (TimeSpan data) { Data = data; }
            public static implicit operator EstimatedFlightDurationTimeSpan (TimeSpan data) { return new EstimatedFlightDurationTimeSpan (data); }
        }

        public class EstimatedFlightDurationstring : IEstimatedFlightDuration<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public EstimatedFlightDurationstring () { }
            public EstimatedFlightDurationstring (string data) { Data = data; }
            public static implicit operator EstimatedFlightDurationstring (string data) { return new EstimatedFlightDurationstring (data); }
        }


        public interface IProvider : IWrapper { }
        public interface IProvider<T> : IProvider { new T Data { get; set; } }
        public class ProviderOrganization : IProvider<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ProviderOrganization () { }
            public ProviderOrganization (Organization data) { Data = data; }
            public static implicit operator ProviderOrganization (Organization data) { return new ProviderOrganization (data); }
        }

        public class ProviderPerson : IProvider<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ProviderPerson () { }
            public ProviderPerson (Person data) { Data = data; }
            public static implicit operator ProviderPerson (Person data) { return new ProviderPerson (data); }
        }


        public interface ISeller : IWrapper { }
        public interface ISeller<T> : ISeller { new T Data { get; set; } }
        public class SellerOrganization : ISeller<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SellerOrganization () { }
            public SellerOrganization (Organization data) { Data = data; }
            public static implicit operator SellerOrganization (Organization data) { return new SellerOrganization (data); }
        }

        public class SellerPerson : ISeller<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SellerPerson () { }
            public SellerPerson (Person data) { Data = data; }
            public static implicit operator SellerPerson (Person data) { return new SellerPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [DataMember(Name = "aircraft", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAircraft>? Aircraft { get; set; } //string, Vehicle

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [DataMember(Name = "arrivalAirport", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Airport>? ArrivalAirport { get; set; } 

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [DataMember(Name = "arrivalGate", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalGate { get; set; } 

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [DataMember(Name = "arrivalTerminal", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalTerminal { get; set; } 

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ArrivalTime { get; set; } 

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BoardingPolicyType>? BoardingPolicy { get; set; } 

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [DataMember(Name = "departureAirport", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Airport>? DepartureAirport { get; set; } 

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [DataMember(Name = "departureGate", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DepartureGate { get; set; } 

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [DataMember(Name = "departureTerminal", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DepartureTerminal { get; set; } 

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DepartureTime { get; set; } 

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [DataMember(Name = "estimatedFlightDuration", Order = 216)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<IEstimatedFlightDuration>? EstimatedFlightDuration { get; set; } //TimeSpan?, string

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [DataMember(Name = "flightDistance", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FlightDistance { get; set; } 

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [DataMember(Name = "flightNumber", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FlightNumber { get; set; } 

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [DataMember(Name = "mealService", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MealService { get; set; } 

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProvider>? Provider { get; set; } //Organization, Person

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISeller>? Seller { get; set; } //Organization, Person

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [DataMember(Name = "webCheckinTime", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? WebCheckinTime { get; set; } 
    }
}
