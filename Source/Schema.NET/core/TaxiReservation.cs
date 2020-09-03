namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
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
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TaxiReservation : Reservation, ITaxiReservation, IEquatable<TaxiReservation>
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

        /// <inheritdoc/>
        public bool Equals(TaxiReservation other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.PartySize == other.PartySize &&
                this.PickupLocation == other.PickupLocation &&
                this.PickupTime == other.PickupTime &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TaxiReservation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.PartySize)
            .And(this.PickupLocation)
            .And(this.PickupTime)
            .And(base.GetHashCode());
    }
}
