namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    [DataContract]
    public partial class RsvpAction : InformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RsvpAction";

        /// <summary>
        /// If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [DataMember(Name = "additionalNumberOfGuests", Order = 506)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 507)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Comment>? Comment { get; set; }

        /// <summary>
        /// The response (yes, no, maybe) to the RSVP.
        /// </summary>
        [DataMember(Name = "rsvpResponse", Order = 508)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RsvpResponseType?>? RsvpResponse { get; set; }
    }
}
