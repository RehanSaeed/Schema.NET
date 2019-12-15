namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An art gallery.
    /// </summary>
    public partial interface IArtGallery : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An art gallery.
    /// </summary>
    [DataContract]
    public partial class ArtGallery : EntertainmentBusiness, IArtGallery, IEquatable<ArtGallery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ArtGallery";

        /// <inheritdoc/>
        public bool Equals(ArtGallery other)
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
        public override bool Equals(object obj) => this.Equals(obj as ArtGallery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
