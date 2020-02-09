namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.
    /// </summary>
    public partial interface IMediaGallery : ICollectionPage
    {
    }

    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.
    /// </summary>
    [DataContract]
    public partial class MediaGallery : CollectionPage, IMediaGallery, IEquatable<MediaGallery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaGallery";

        /// <inheritdoc/>
        public bool Equals(MediaGallery other)
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
        public override bool Equals(object obj) => this.Equals(obj as MediaGallery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
