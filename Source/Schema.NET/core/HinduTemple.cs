namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Hindu temple.
    /// </summary>
    public partial interface IHinduTemple : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Hindu temple.
    /// </summary>
    [DataContract]
    public partial class HinduTemple : PlaceOfWorship, IHinduTemple, IEquatable<HinduTemple>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HinduTemple";

        /// <inheritdoc/>
        public bool Equals(HinduTemple other)
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
        public override bool Equals(object obj) => this.Equals(obj as HinduTemple);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
