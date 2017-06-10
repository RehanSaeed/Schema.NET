namespace Schema.NET
{
    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// </summary>
    public enum DriveWheelConfigurationValue
    {
        /// <summary>
        /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
        /// </summary>
        AllWheelDriveConfiguration,

        /// <summary>
        /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
        /// </summary>
        FourWheelDriveConfiguration,

        /// <summary>
        /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
        /// </summary>
        FrontWheelDriveConfiguration,

        /// <summary>
        /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
        /// </summary>
        RearWheelDriveConfiguration
    }
}
