namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated status values for Reservation.
    /// </summary>
    public enum ReservationStatusType
    {
        /// <summary>
        /// The status for a previously confirmed reservation that is now cancelled.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReservationCancelled")]
        ReservationCancelled,

        /// <summary>
        /// The status of a confirmed reservation.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReservationConfirmed")]
        ReservationConfirmed,

        /// <summary>
        /// The status of a reservation on hold pending an update like credit card number or flight changes.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReservationHold")]
        ReservationHold,

        /// <summary>
        /// The status of a reservation when a request has been sent, but not confirmed.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReservationPending")]
        ReservationPending
    }
}
