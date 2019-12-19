namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The status of an Action.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or driving to a location).
        /// </summary>
        [EnumMember(Value = "https://schema.org/ActiveActionStatus")]
        ActiveActionStatus,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CompletedActionStatus")]
        CompletedActionStatus,

        /// <summary>
        /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
        /// </summary>
        [EnumMember(Value = "https://schema.org/FailedActionStatus")]
        FailedActionStatus,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PotentialActionStatus")]
        PotentialActionStatus,
    }
}
