namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    public partial interface IGatedResidenceCommunity : IResidence
    {
    }

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    [DataContract]
    public partial class GatedResidenceCommunity : Residence, IGatedResidenceCommunity, IEquatable<GatedResidenceCommunity>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GatedResidenceCommunity";

        /// <inheritdoc/>
        public bool Equals(GatedResidenceCommunity other)
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
        public override bool Equals(object obj) => this.Equals(obj as GatedResidenceCommunity);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
