namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A zoo.
    /// </summary>
    public partial interface IZoo : ICivicStructure
    {
    }

    /// <summary>
    /// A zoo.
    /// </summary>
    [DataContract]
    public partial class Zoo : CivicStructure, IZoo, IEquatable<Zoo>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Zoo";

        /// <inheritdoc/>
        public bool Equals(Zoo other)
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
        public override bool Equals(object obj) => this.Equals(obj as Zoo);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
