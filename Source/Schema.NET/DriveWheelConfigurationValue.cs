namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// </summary>
    [DataContract]
    public class DriveWheelConfigurationValue : QualitativeValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DriveWheelConfigurationValue";
    }
}
