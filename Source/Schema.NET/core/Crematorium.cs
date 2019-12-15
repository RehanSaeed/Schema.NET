namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A crematorium.
    /// </summary>
    public partial interface ICrematorium : ICivicStructure
    {
    }

    /// <summary>
    /// A crematorium.
    /// </summary>
    [DataContract]
    public partial class Crematorium : CivicStructure, ICrematorium, IEquatable<Crematorium>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Crematorium";

        /// <inheritdoc/>
        public bool Equals(Crematorium other)
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
        public override bool Equals(object obj) => this.Equals(obj as Crematorium);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
