namespace Schema.NET
{
    /// <summary>
    /// Enumerated status values for Reservation.
    /// </summary>
    public enum ReservationStatusType
    {
        /// <summary>
        /// The status for a previously confirmed reservation that is now cancelled.
        /// </summary>
        ReservationCancelled,

        /// <summary>
        /// The status of a confirmed reservation.
        /// </summary>
        ReservationConfirmed,

        /// <summary>
        /// The status of a reservation on hold pending an update like credit card number or flight changes.
        /// </summary>
        ReservationHold,

        /// <summary>
        /// The status of a reservation when a request has been sent, but not confirmed.
        /// </summary>
        ReservationPending
    }
}
