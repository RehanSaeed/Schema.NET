namespace Schema.NET
{
    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    public enum BoardingPolicyType
    {
        /// <summary>
        /// The airline boards by groups based on check-in time, priority, etc.
        /// </summary>
        GroupBoardingPolicy,

        /// <summary>
        /// The airline boards by zones of the plane.
        /// </summary>
        ZoneBoardingPolicy
    }
}
