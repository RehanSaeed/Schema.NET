namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    public partial interface IFireStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    [DataContract]
    public partial class FireStation : CivicStructureAndEmergencyService, IFireStation, IEquatable<FireStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FireStation";

        /// <inheritdoc/>
        public bool Equals(FireStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as FireStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
