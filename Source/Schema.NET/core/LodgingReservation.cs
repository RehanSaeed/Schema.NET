namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial interface ILodgingReservation : IReservation
    {
        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> CheckoutTime { get; set; }

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        OneOrMany<string> LodgingUnitDescription { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        OneOrMany<string> LodgingUnitType { get; set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        Values<int?, IQuantitativeValue> NumAdults { get; set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        Values<int?, IQuantitativeValue> NumChildren { get; set; }
    }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class LodgingReservation : Reservation, ILodgingReservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> CheckoutTime { get; set; }

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LodgingUnitDescription { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LodgingUnitType { get; set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumAdults { get; set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumChildren { get; set; }
    }
}
