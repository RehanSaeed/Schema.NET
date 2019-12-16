namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music venue.
    /// </summary>
    public partial interface IMusicVenue : ICivicStructure
    {
    }

    /// <summary>
    /// A music venue.
    /// </summary>
    [DataContract]
    public partial class MusicVenue : CivicStructure, IMusicVenue, IEquatable<MusicVenue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicVenue";

        /// <inheritdoc/>
        public bool Equals(MusicVenue other)
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
        public override bool Equals(object obj) => this.Equals(obj as MusicVenue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
