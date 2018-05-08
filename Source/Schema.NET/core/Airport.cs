namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An airport.
    /// </summary>
    public partial interface IAirport : ICivicStructure
    {
        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        OneOrMany<string>? IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        OneOrMany<string>? IcaoCode { get; set; }
    }

    /// <summary>
    /// An airport.
    /// </summary>
    [DataContract]
    public partial class Airport : CivicStructure, IAirport
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Airport";

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        [DataMember(Name = "icaoCode", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? IcaoCode { get; set; }
    }
}
