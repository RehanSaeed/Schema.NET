namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A police station.
    /// </summary>
    public partial interface IPoliceStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A police station.
    /// </summary>
    [DataContract]
    public partial class PoliceStation : CivicStructureAndEmergencyService, IPoliceStation, IEquatable<PoliceStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PoliceStation";

        /// <inheritdoc/>
        public bool Equals(PoliceStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as PoliceStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
