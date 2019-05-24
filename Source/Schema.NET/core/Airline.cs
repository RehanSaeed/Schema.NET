namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    public partial interface IAirline : IOrganization
    {
        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        OneOrMany<string> IataCode { get; set; }
    }

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    [DataContract]
    public partial class Airline : Organization, IAirline
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Airline";

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IataCode { get; set; }
    }
}
