namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    [DataContract]
    public class BusTrip : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BusTrip";

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider")]
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
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [DataMember(Name = "busName")]
        public string BusName { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [DataMember(Name = "departureBusStop")]
        public object DepartureBusStop { get; protected set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [IgnoreDataMember]
        public BusStation DepartureBusStopBusStation
        {
            get => this.DepartureBusStop as BusStation;
            set => this.DepartureBusStop = value;
        }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [IgnoreDataMember]
        public BusStop DepartureBusStopBusStop
        {
            get => this.DepartureBusStop as BusStop;
            set => this.DepartureBusStop = value;
        }

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [DataMember(Name = "arrivalBusStop")]
        public object ArrivalBusStop { get; protected set; }

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [IgnoreDataMember]
        public BusStation ArrivalBusStopBusStation
        {
            get => this.ArrivalBusStop as BusStation;
            set => this.ArrivalBusStop = value;
        }

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [IgnoreDataMember]
        public BusStop ArrivalBusStopBusStop
        {
            get => this.ArrivalBusStop as BusStop;
            set => this.ArrivalBusStop = value;
        }

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime")]
        public DateTimeOffset ArrivalTime { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [DataMember(Name = "busNumber")]
        public string BusNumber { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime")]
        public DateTimeOffset DepartureTime { get; set; }
    }
}
