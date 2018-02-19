using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An image file.
    /// </summary>
    [DataContract]
    public partial class ImageObject : MediaObject
    {
        public interface IExifData : IWrapper { }
        public interface IExifData<T> : IExifData { new T Data { get; set; } }
        public class ExifDataPropertyValue : IExifData<PropertyValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PropertyValue) value; } }
            public virtual PropertyValue Data { get; set; }
            public ExifDataPropertyValue () { }
            public ExifDataPropertyValue (PropertyValue data) { Data = data; }
            public static implicit operator ExifDataPropertyValue (PropertyValue data) { return new ExifDataPropertyValue (data); }
        }

        public class ExifDatastring : IExifData<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ExifDatastring () { }
            public ExifDatastring (string data) { Data = data; }
            public static implicit operator ExifDatastring (string data) { return new ExifDatastring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageObject";

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Caption { get; set; } 

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [DataMember(Name = "exifData", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IExifData>? ExifData { get; set; } //PropertyValue, string

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [DataMember(Name = "representativeOfPage", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? RepresentativeOfPage { get; set; } 

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject>? Thumbnail { get; set; } 
    }
}
