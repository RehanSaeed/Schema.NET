namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    [DataContract]
    public class RsvpAction : InformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RsvpAction";

        /// <summary>
        /// If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [DataMember(Name = "additionalNumberOfGuests")]
        public decimal AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment")]
        public Comment Comment { get; set; }

        /// <summary>
        /// The response (yes, no, maybe) to the RSVP.
        /// </summary>
        [DataMember(Name = "rsvpResponse")]
        public RsvpResponseType RsvpResponse { get; set; }
    }
}
