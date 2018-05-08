namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// </summary>
    public partial interface IMotorizedBicycle : IVehicle
    {
    }

    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// </summary>
    [DataContract]
    public partial class MotorizedBicycle : Vehicle, IMotorizedBicycle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MotorizedBicycle";
    }
}
