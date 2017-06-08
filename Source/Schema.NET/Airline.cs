namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    [DataContract]
    public class Airline : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Airline";

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode")]
        public string IataCode { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy")]
        public BoardingPolicyType BoardingPolicy { get; set; }
    }
}
