namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    public partial interface ICableOrSatelliteService : IService
    {
    }

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    [DataContract]
    public partial class CableOrSatelliteService : Service, ICableOrSatelliteService, IEquatable<CableOrSatelliteService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CableOrSatelliteService";

        /// <inheritdoc/>
        public bool Equals(CableOrSatelliteService other)
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
        public override bool Equals(object obj) => this.Equals(obj as CableOrSatelliteService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
