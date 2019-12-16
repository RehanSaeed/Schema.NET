namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    public partial interface ICoverArt : IVisualArtwork
    {
    }

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    [DataContract]
    public partial class CoverArt : VisualArtwork, ICoverArt, IEquatable<CoverArt>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CoverArt";

        /// <inheritdoc/>
        public bool Equals(CoverArt other)
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
        public override bool Equals(object obj) => this.Equals(obj as CoverArt);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
