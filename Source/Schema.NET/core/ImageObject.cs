namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An image file.
    /// </summary>
    [DataContract]
    public partial class ImageObject : MediaObject
    {
        public interface ICaption : IValue {}
        public interface ICaption<T> : ICaption { new T Value { get; } }
        public class OneOrManyCaption : OneOrMany<ICaption>
        {
            public OneOrManyCaption(ICaption item) : base(item) { }
            public OneOrManyCaption(IEnumerable<ICaption> items) : base(items) { }
            public static implicit operator OneOrManyCaption (string value) { return new OneOrManyCaption (new Captionstring (value)); }
            public static implicit operator OneOrManyCaption (string[] values) { return new OneOrManyCaption (values.Select(v => (ICaption) new Captionstring (v))); }
            public static implicit operator OneOrManyCaption (List<string> values) { return new OneOrManyCaption (values.Select(v => (ICaption) new Captionstring (v))); }
        }
        public struct Captionstring : ICaption<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Captionstring (string value) { Value = value; }
            public static implicit operator Captionstring (string value) { return new Captionstring (value); }
        }

        public interface IExifData : IValue {}
        public interface IExifData<T> : IExifData { new T Value { get; } }
        public class OneOrManyExifData : OneOrMany<IExifData>
        {
            public OneOrManyExifData(IExifData item) : base(item) { }
            public OneOrManyExifData(IEnumerable<IExifData> items) : base(items) { }
            public static implicit operator OneOrManyExifData (PropertyValue value) { return new OneOrManyExifData (new ExifDataPropertyValue (value)); }
            public static implicit operator OneOrManyExifData (PropertyValue[] values) { return new OneOrManyExifData (values.Select(v => (IExifData) new ExifDataPropertyValue (v))); }
            public static implicit operator OneOrManyExifData (List<PropertyValue> values) { return new OneOrManyExifData (values.Select(v => (IExifData) new ExifDataPropertyValue (v))); }
            public static implicit operator OneOrManyExifData (string value) { return new OneOrManyExifData (new ExifDatastring (value)); }
            public static implicit operator OneOrManyExifData (string[] values) { return new OneOrManyExifData (values.Select(v => (IExifData) new ExifDatastring (v))); }
            public static implicit operator OneOrManyExifData (List<string> values) { return new OneOrManyExifData (values.Select(v => (IExifData) new ExifDatastring (v))); }
        }
        public struct ExifDataPropertyValue : IExifData<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public ExifDataPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator ExifDataPropertyValue (PropertyValue value) { return new ExifDataPropertyValue (value); }
        }
        public struct ExifDatastring : IExifData<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExifDatastring (string value) { Value = value; }
            public static implicit operator ExifDatastring (string value) { return new ExifDatastring (value); }
        }

        public interface IRepresentativeOfPage : IValue {}
        public interface IRepresentativeOfPage<T> : IRepresentativeOfPage { new T Value { get; } }
        public class OneOrManyRepresentativeOfPage : OneOrMany<IRepresentativeOfPage>
        {
            public OneOrManyRepresentativeOfPage(IRepresentativeOfPage item) : base(item) { }
            public OneOrManyRepresentativeOfPage(IEnumerable<IRepresentativeOfPage> items) : base(items) { }
            public static implicit operator OneOrManyRepresentativeOfPage (bool value) { return new OneOrManyRepresentativeOfPage (new RepresentativeOfPagebool (value)); }
            public static implicit operator OneOrManyRepresentativeOfPage (bool[] values) { return new OneOrManyRepresentativeOfPage (values.Select(v => (IRepresentativeOfPage) new RepresentativeOfPagebool (v))); }
            public static implicit operator OneOrManyRepresentativeOfPage (List<bool> values) { return new OneOrManyRepresentativeOfPage (values.Select(v => (IRepresentativeOfPage) new RepresentativeOfPagebool (v))); }
        }
        public struct RepresentativeOfPagebool : IRepresentativeOfPage<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public RepresentativeOfPagebool (bool value) { Value = value; }
            public static implicit operator RepresentativeOfPagebool (bool value) { return new RepresentativeOfPagebool (value); }
        }

        public interface IThumbnail : IValue {}
        public interface IThumbnail<T> : IThumbnail { new T Value { get; } }
        public class OneOrManyThumbnail : OneOrMany<IThumbnail>
        {
            public OneOrManyThumbnail(IThumbnail item) : base(item) { }
            public OneOrManyThumbnail(IEnumerable<IThumbnail> items) : base(items) { }
            public static implicit operator OneOrManyThumbnail (ImageObject value) { return new OneOrManyThumbnail (new ThumbnailImageObject (value)); }
            public static implicit operator OneOrManyThumbnail (ImageObject[] values) { return new OneOrManyThumbnail (values.Select(v => (IThumbnail) new ThumbnailImageObject (v))); }
            public static implicit operator OneOrManyThumbnail (List<ImageObject> values) { return new OneOrManyThumbnail (values.Select(v => (IThumbnail) new ThumbnailImageObject (v))); }
        }
        public struct ThumbnailImageObject : IThumbnail<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public ThumbnailImageObject (ImageObject value) { Value = value; }
            public static implicit operator ThumbnailImageObject (ImageObject value) { return new ThumbnailImageObject (value); }
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
        public OneOrManyCaption Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [DataMember(Name = "exifData", Order = 307)]
        public OneOrManyExifData ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [DataMember(Name = "representativeOfPage", Order = 308)]
        public OneOrManyRepresentativeOfPage RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 309)]
        public OneOrManyThumbnail Thumbnail { get; set; }
    }
}
