namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// </summary>
    public enum ContactPointOption
    {
        /// <summary>
        /// Uses devices to support users with hearing impairments.
        /// </summary>
        [EnumMember(Value = "http://schema.org/HearingImpairedSupported")]
        HearingImpairedSupported,

        /// <summary>
        /// The associated telephone number is toll free.
        /// </summary>
        [EnumMember(Value = "http://schema.org/TollFree")]
        TollFree
    }
}
