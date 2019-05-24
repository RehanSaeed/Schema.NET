namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// </summary>
    public enum DriveWheelConfigurationValue
    {
        /// <summary>
        /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
        /// </summary>
        [EnumMember(Value = "http://schema.org/AllWheelDriveConfiguration")]
        AllWheelDriveConfiguration,

        /// <summary>
        /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FourWheelDriveConfiguration")]
        FourWheelDriveConfiguration,

        /// <summary>
        /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FrontWheelDriveConfiguration")]
        FrontWheelDriveConfiguration,

        /// <summary>
        /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RearWheelDriveConfiguration")]
        RearWheelDriveConfiguration
    }
}
