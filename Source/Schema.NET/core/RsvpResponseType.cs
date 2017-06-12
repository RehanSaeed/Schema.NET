namespace Schema.NET
{
    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// </summary>
    public enum RsvpResponseType
    {
        /// <summary>
        /// The invitee may or may not attend.
        /// </summary>
        RsvpResponseMaybe,

        /// <summary>
        /// The invitee will not attend.
        /// </summary>
        RsvpResponseNo,

        /// <summary>
        /// The invitee will attend.
        /// </summary>
        RsvpResponseYes
    }
}
