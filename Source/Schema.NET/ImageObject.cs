namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An image file.
    /// </summary>
    [DataContract]
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ImageObject";

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [DataMember(Name = "exifData")]
        public object ExifData { get; protected set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [IgnoreDataMember]
        public PropertyValue ExifDataPropertyValue
        {
            get => this.ExifData as PropertyValue;
            set => this.ExifData = value;
        }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [IgnoreDataMember]
        public string ExifDataText
        {
            get => this.ExifData as string;
            set => this.ExifData = value;
        }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [DataMember(Name = "representativeOfPage")]
        public bool RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail")]
        public ImageObject Thumbnail { get; set; }

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption")]
        public string Caption { get; set; }
    }
}
