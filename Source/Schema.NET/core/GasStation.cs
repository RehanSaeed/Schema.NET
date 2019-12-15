namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A gas station.
    /// </summary>
    public partial interface IGasStation : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A gas station.
    /// </summary>
    [DataContract]
    public partial class GasStation : AutomotiveBusiness, IGasStation, IEquatable<GasStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GasStation";

        /// <inheritdoc/>
        public bool Equals(GasStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as GasStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
