namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating a steering position.
    /// </summary>
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
