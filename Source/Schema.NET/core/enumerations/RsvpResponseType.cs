namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RsvpResponseType
    {
        /// <summary>
        /// The invitee may or may not attend.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RsvpResponseMaybe")]
        RsvpResponseMaybe,

        /// <summary>
        /// The invitee will not attend.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RsvpResponseNo")]
        RsvpResponseNo,

        /// <summary>
        /// The invitee will attend.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RsvpResponseYes")]
        RsvpResponseYes
    }
}
