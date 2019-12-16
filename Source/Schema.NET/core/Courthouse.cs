namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A courthouse.
    /// </summary>
    public partial interface ICourthouse : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A courthouse.
    /// </summary>
    [DataContract]
    public partial class Courthouse : GovernmentBuilding, ICourthouse, IEquatable<Courthouse>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Courthouse";

        /// <inheritdoc/>
        public bool Equals(Courthouse other)
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
        public override bool Equals(object obj) => this.Equals(obj as Courthouse);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
