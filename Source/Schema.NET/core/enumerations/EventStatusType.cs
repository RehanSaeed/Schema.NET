namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventStatusType
    {
        /// <summary>
        /// The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).
        /// </summary>
        [EnumMember(Value = "https://schema.org/EventCancelled")]
        EventCancelled,

        /// <summary>
        /// Indicates that the event was changed to allow online participation. See &lt;a class="localLink" href="https://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; for specifics of whether it is now fully or partially online.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EventMovedOnline")]
        EventMovedOnline,

        /// <summary>
        /// The event has been postponed and no new date has been set. The event's previousStartDate should be set.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EventPostponed")]
        EventPostponed,

        /// <summary>
        /// The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated).
        /// </summary>
        [EnumMember(Value = "https://schema.org/EventRescheduled")]
        EventRescheduled,

        /// <summary>
        /// The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EventScheduled")]
        EventScheduled,
    }
}
