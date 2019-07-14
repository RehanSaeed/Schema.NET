namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A value indicating a steering position.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SteeringPositionValue
    {
        /// <summary>
        /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
        /// </summary>
        [EnumMember(Value = "http://schema.org/LeftHandDriving")]
        LeftHandDriving,

        /// <summary>
        /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
        /// </summary>
        [EnumMember(Value = "http://schema.org/RightHandDriving")]
        RightHandDriving
    }
}
