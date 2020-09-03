namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An image file.
    /// </summary>
    public partial interface IImageObject : IMediaObject
    {
        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        Values<IPropertyValue, string> ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        OneOrMany<bool?> RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject> Thumbnail { get; set; }
    }

    /// <summary>
    /// An image file.
    /// </summary>
    [DataContract]
    public partial class ImageObject : MediaObject, IImageObject, IEquatable<ImageObject>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageObject";

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "caption", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [DataMember(Name = "exifData", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, string> ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [DataMember(Name = "representativeOfPage", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> Thumbnail { get; set; }

        /// <inheritdoc/>
        public bool Equals(ImageObject other)
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
                this.Caption == other.Caption &&
                this.ExifData == other.ExifData &&
                this.RepresentativeOfPage == other.RepresentativeOfPage &&
                this.Thumbnail == other.Thumbnail &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ImageObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Caption)
            .And(this.ExifData)
            .And(this.RepresentativeOfPage)
            .And(this.Thumbnail)
            .And(base.GetHashCode());
    }
}
