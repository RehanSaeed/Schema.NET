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
    public partial class MotorizedBicycle : Vehicle, IMotorizedBicycle, IEquatable<MotorizedBicycle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MotorizedBicycle";

        /// <inheritdoc/>
        public bool Equals(MotorizedBicycle other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MotorizedBicycle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
