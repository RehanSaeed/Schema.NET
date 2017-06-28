namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An airport.
    /// </summary>
    [DataContract]
    public partial class Airport : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Airport";

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        [DataMember(Name = "icaoCode", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IcaoCode { get; set; }
    }
}
