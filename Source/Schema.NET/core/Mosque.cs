namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A mosque.
    /// </summary>
    public partial interface IMosque : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A mosque.
    /// </summary>
    [DataContract]
    public partial class Mosque : PlaceOfWorship, IMosque, IEquatable<Mosque>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Mosque";

        /// <inheritdoc/>
        public bool Equals(Mosque other)
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
        public override bool Equals(object obj) => this.Equals(obj as Mosque);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
