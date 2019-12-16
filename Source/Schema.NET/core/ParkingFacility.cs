namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    public partial interface IParkingFacility : ICivicStructure
    {
    }

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    [DataContract]
    public partial class ParkingFacility : CivicStructure, IParkingFacility, IEquatable<ParkingFacility>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParkingFacility";

        /// <inheritdoc/>
        public bool Equals(ParkingFacility other)
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
        public override bool Equals(object obj) => this.Equals(obj as ParkingFacility);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
