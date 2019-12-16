namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial interface IFoodEstablishmentReservation : IReservation
    {
        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        Values<int?, IQuantitativeValue> PartySize { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }
    }

    /// <summary>
    /// A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishmentReservation : Reservation, IFoodEstablishmentReservation, IEquatable<FoodEstablishmentReservation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishmentReservation";

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> PartySize { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        /// <inheritdoc/>
        public bool Equals(FoodEstablishmentReservation other)
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
                this.EndTime == other.EndTime &&
                this.PartySize == other.PartySize &&
                this.StartTime == other.StartTime &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FoodEstablishmentReservation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EndTime)
            .And(this.PartySize)
            .And(this.StartTime)
            .And(base.GetHashCode());
    }
}
