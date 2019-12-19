namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoardingPolicyType
    {
        /// <summary>
        /// The airline boards by groups based on check-in time, priority, etc.
        /// </summary>
        [EnumMember(Value = "https://schema.org/GroupBoardingPolicy")]
        GroupBoardingPolicy,

        /// <summary>
        /// The airline boards by zones of the plane.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ZoneBoardingPolicy")]
        ZoneBoardingPolicy,
    }
}
