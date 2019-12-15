namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    public partial interface IMotorcycle : IVehicle
    {
    }

    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    [DataContract]
    public partial class Motorcycle : Vehicle, IMotorcycle, IEquatable<Motorcycle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Motorcycle";
    }
}
