namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class LodgingReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? CheckoutTime { get; set; }

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LodgingUnitDescription { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LodgingUnitType { get; set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue, int?>? NumAdults { get; set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumChildren { get; set; }
    }
}
