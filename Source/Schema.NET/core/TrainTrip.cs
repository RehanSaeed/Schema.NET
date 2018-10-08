namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    [DataContract]
    public partial class TrainTrip : Trip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainTrip";

        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        [DataMember(Name = "arrivalPlatform", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ArrivalPlatform { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [DataMember(Name = "arrivalStation", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<TrainStation>? ArrivalStation { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [DataMember(Name = "departurePlatform", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? DeparturePlatform { get; set; }

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [DataMember(Name = "departureStation", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<TrainStation>? DepartureStation { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [DataMember(Name = "trainName", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [DataMember(Name = "trainNumber", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TrainNumber { get; set; }
    }
}
