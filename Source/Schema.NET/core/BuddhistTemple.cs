namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    public partial interface IBuddhistTemple : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    [DataContract]
    public partial class BuddhistTemple : PlaceOfWorship, IBuddhistTemple, IEquatable<BuddhistTemple>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BuddhistTemple";

        /// <inheritdoc/>
        public bool Equals(BuddhistTemple other)
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
        public override bool Equals(object obj) => this.Equals(obj as BuddhistTemple);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
