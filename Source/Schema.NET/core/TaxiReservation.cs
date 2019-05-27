namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial interface ITaxiReservation : IReservation
    {
        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        Values<int?, IQuantitativeValue> PartySize { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        OneOrMany<IPlace> PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        OneOrMany<DateTimeOffset?> PickupTime { get; set; }
    }

    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TaxiReservation : Reservation, ITaxiReservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiReservation";

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> PartySize { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> PickupTime { get; set; }
    }
}
