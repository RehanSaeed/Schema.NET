namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    public partial interface IOceanBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    [DataContract]
    public partial class OceanBodyOfWater : BodyOfWater, IOceanBodyOfWater, IEquatable<OceanBodyOfWater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OceanBodyOfWater";

        /// <inheritdoc/>
        public bool Equals(OceanBodyOfWater other)
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
        public override bool Equals(object obj) => this.Equals(obj as OceanBodyOfWater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
