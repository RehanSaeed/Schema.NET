namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Enumerated status values for Reservation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReservationStatusType
    {
        /// <summary>
        /// The status for a previously confirmed reservation that is now cancelled.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ReservationCancelled")]
        ReservationCancelled,

        /// <summary>
        /// The status of a confirmed reservation.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ReservationConfirmed")]
        ReservationConfirmed,

        /// <summary>
        /// The status of a reservation on hold pending an update like credit card number or flight changes.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ReservationHold")]
        ReservationHold,

        /// <summary>
        /// The status of a reservation when a request has been sent, but not confirmed.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ReservationPending")]
        ReservationPending
    }
}
