namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The status of a medical study. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalStudyStatus
    {
        /// <summary>
        /// Active, but not recruiting new participants.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ActiveNotRecruiting")]
        ActiveNotRecruiting,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Completed")]
        Completed,

        /// <summary>
        /// Enrolling participants by invitation only.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EnrollingByInvitation")]
        EnrollingByInvitation,

        /// <summary>
        /// Not yet recruiting.
        /// </summary>
        [EnumMember(Value = "https://schema.org/NotYetRecruiting")]
        NotYetRecruiting,

        /// <summary>
        /// Recruiting participants.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Recruiting")]
        Recruiting,

        /// <summary>
        /// Results are available.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ResultsAvailable")]
        ResultsAvailable,

        /// <summary>
        /// Results are not available.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ResultsNotAvailable")]
        ResultsNotAvailable,

        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Suspended")]
        Suspended,

        /// <summary>
        /// Terminated.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Terminated")]
        Terminated,

        /// <summary>
        /// Withdrawn.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Withdrawn")]
        Withdrawn
    }
}
