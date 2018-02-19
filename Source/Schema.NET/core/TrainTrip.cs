using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    [DataContract]
    public partial class TrainTrip : Intangible
    {
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
        public override string Type => "TrainTrip";

        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        [DataMember(Name = "arrivalPlatform", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalPlatform { get; set; } 

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [DataMember(Name = "arrivalStation", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<TrainStation>? ArrivalStation { get; set; } 

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ArrivalTime { get; set; } 

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [DataMember(Name = "departurePlatform", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DeparturePlatform { get; set; } 

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [DataMember(Name = "departureStation", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<TrainStation>? DepartureStation { get; set; } 

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

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [DataMember(Name = "trainName", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TrainName { get; set; } 

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [DataMember(Name = "trainNumber", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TrainNumber { get; set; } 
    }
}
