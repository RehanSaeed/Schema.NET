using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    [DataContract]
    public partial class BusTrip : Intangible
    {
        public interface IArrivalBusStop : IWrapper { }
        public interface IArrivalBusStop<T> : IArrivalBusStop { new T Data { get; set; } }
        public class ArrivalBusStopBusStation : IArrivalBusStop<BusStation>
        {
            object IWrapper.Data { get { return Data; } set { Data = (BusStation) value; } }
            public virtual BusStation Data { get; set; }
            public ArrivalBusStopBusStation () { }
            public ArrivalBusStopBusStation (BusStation data) { Data = data; }
            public static implicit operator ArrivalBusStopBusStation (BusStation data) { return new ArrivalBusStopBusStation (data); }
        }

        public class ArrivalBusStopBusStop : IArrivalBusStop<BusStop>
        {
            object IWrapper.Data { get { return Data; } set { Data = (BusStop) value; } }
            public virtual BusStop Data { get; set; }
            public ArrivalBusStopBusStop () { }
            public ArrivalBusStopBusStop (BusStop data) { Data = data; }
            public static implicit operator ArrivalBusStopBusStop (BusStop data) { return new ArrivalBusStopBusStop (data); }
        }


        public interface IDepartureBusStop : IWrapper { }
        public interface IDepartureBusStop<T> : IDepartureBusStop { new T Data { get; set; } }
        public class DepartureBusStopBusStation : IDepartureBusStop<BusStation>
        {
            object IWrapper.Data { get { return Data; } set { Data = (BusStation) value; } }
            public virtual BusStation Data { get; set; }
            public DepartureBusStopBusStation () { }
            public DepartureBusStopBusStation (BusStation data) { Data = data; }
            public static implicit operator DepartureBusStopBusStation (BusStation data) { return new DepartureBusStopBusStation (data); }
        }

        public class DepartureBusStopBusStop : IDepartureBusStop<BusStop>
        {
            object IWrapper.Data { get { return Data; } set { Data = (BusStop) value; } }
            public virtual BusStop Data { get; set; }
            public DepartureBusStopBusStop () { }
            public DepartureBusStopBusStop (BusStop data) { Data = data; }
            public static implicit operator DepartureBusStopBusStop (BusStop data) { return new DepartureBusStopBusStop (data); }
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusTrip";

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [DataMember(Name = "arrivalBusStop", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IArrivalBusStop>? ArrivalBusStop { get; set; } //BusStation, BusStop

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ArrivalTime { get; set; } 

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [DataMember(Name = "busName", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BusName { get; set; } 

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [DataMember(Name = "busNumber", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BusNumber { get; set; } 

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [DataMember(Name = "departureBusStop", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IDepartureBusStop>? DepartureBusStop { get; set; } //BusStation, BusStop

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DepartureTime { get; set; } 

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProvider>? Provider { get; set; } //Organization, Person
    }
}
