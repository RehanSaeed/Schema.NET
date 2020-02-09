namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    public partial interface IImageGallery : IMediaGallery
    {
    }

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    [DataContract]
    public partial class ImageGallery : MediaGallery, IImageGallery, IEquatable<ImageGallery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageGallery";

        /// <inheritdoc/>
        public bool Equals(ImageGallery other)
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
        public override bool Equals(object obj) => this.Equals(obj as ImageGallery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
