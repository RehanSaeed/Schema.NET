namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    [DataContract]
    public partial class BusTrip : Trip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusTrip";

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [DataMember(Name = "arrivalBusStop", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusStation, BusStop>? ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [DataMember(Name = "busName", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [DataMember(Name = "busNumber", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [DataMember(Name = "departureBusStop", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusStation, BusStop>? DepartureBusStop { get; set; }
    }
}
