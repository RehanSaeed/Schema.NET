namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    [DataContract]
    public class TrainTrip : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TrainTrip";

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [DataMember(Name = "departureStation")]
        public TrainStation DepartureStation { get; set; }

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
        /// The platform where the train arrives.
        /// </summary>
        [DataMember(Name = "arrivalPlatform")]
        public string ArrivalPlatform { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [DataMember(Name = "departurePlatform")]
        public string DeparturePlatform { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [DataMember(Name = "trainName")]
        public string TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [DataMember(Name = "trainNumber")]
        public string TrainNumber { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [DataMember(Name = "arrivalStation")]
        public TrainStation ArrivalStation { get; set; }

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime")]
        public DateTimeOffset ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime")]
        public DateTimeOffset DepartureTime { get; set; }
    }
}
