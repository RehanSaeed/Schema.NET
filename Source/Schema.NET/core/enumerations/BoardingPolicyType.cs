namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    public enum BoardingPolicyType
    {
        /// <summary>
        /// The airline boards by groups based on check-in time, priority, etc.
        /// </summary>
        [EnumMember(Value = "http://schema.org/GroupBoardingPolicy")]
        GroupBoardingPolicy,

        /// <summary>
        /// The airline boards by zones of the plane.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ZoneBoardingPolicy")]
        ZoneBoardingPolicy
    }
}
