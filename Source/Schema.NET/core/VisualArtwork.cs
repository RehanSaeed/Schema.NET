using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public partial class VisualArtwork : CreativeWork
    {
        public interface IArtEdition : IWrapper { }
        public interface IArtEdition<T> : IArtEdition { new T Data { get; set; } }
        public class ArtEditionint : IArtEdition<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public ArtEditionint () { }
            public ArtEditionint (int data) { Data = data; }
            public static implicit operator ArtEditionint (int data) { return new ArtEditionint (data); }
        }

        public class ArtEditionstring : IArtEdition<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ArtEditionstring () { }
            public ArtEditionstring (string data) { Data = data; }
            public static implicit operator ArtEditionstring (string data) { return new ArtEditionstring (data); }
        }


        public interface IArtform : IWrapper { }
        public interface IArtform<T> : IArtform { new T Data { get; set; } }
        public class Artformstring : IArtform<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Artformstring () { }
            public Artformstring (string data) { Data = data; }
            public static implicit operator Artformstring (string data) { return new Artformstring (data); }
        }

        public class ArtformUri : IArtform<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ArtformUri () { }
            public ArtformUri (Uri data) { Data = data; }
            public static implicit operator ArtformUri (Uri data) { return new ArtformUri (data); }
        }


        public interface IArtMedium : IWrapper { }
        public interface IArtMedium<T> : IArtMedium { new T Data { get; set; } }
        public class ArtMediumstring : IArtMedium<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ArtMediumstring () { }
            public ArtMediumstring (string data) { Data = data; }
            public static implicit operator ArtMediumstring (string data) { return new ArtMediumstring (data); }
        }

        public class ArtMediumUri : IArtMedium<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ArtMediumUri () { }
            public ArtMediumUri (Uri data) { Data = data; }
            public static implicit operator ArtMediumUri (Uri data) { return new ArtMediumUri (data); }
        }


        public interface IArtworkSurface : IWrapper { }
        public interface IArtworkSurface<T> : IArtworkSurface { new T Data { get; set; } }
        public class ArtworkSurfacestring : IArtworkSurface<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ArtworkSurfacestring () { }
            public ArtworkSurfacestring (string data) { Data = data; }
            public static implicit operator ArtworkSurfacestring (string data) { return new ArtworkSurfacestring (data); }
        }

        public class ArtworkSurfaceUri : IArtworkSurface<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ArtworkSurfaceUri () { }
            public ArtworkSurfaceUri (Uri data) { Data = data; }
            public static implicit operator ArtworkSurfaceUri (Uri data) { return new ArtworkSurfaceUri (data); }
        }


        public interface IDepth : IWrapper { }
        public interface IDepth<T> : IDepth { new T Data { get; set; } }
        public class Depthstring : IDepth<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Depthstring () { }
            public Depthstring (string data) { Data = data; }
            public static implicit operator Depthstring (string data) { return new Depthstring (data); }
        }

        public class DepthQuantitativeValue : IDepth<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public DepthQuantitativeValue () { }
            public DepthQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator DepthQuantitativeValue (QuantitativeValue data) { return new DepthQuantitativeValue (data); }
        }


        public interface IHeight : IWrapper { }
        public interface IHeight<T> : IHeight { new T Data { get; set; } }
        public class Heightstring : IHeight<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Heightstring () { }
            public Heightstring (string data) { Data = data; }
            public static implicit operator Heightstring (string data) { return new Heightstring (data); }
        }

        public class HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public HeightQuantitativeValue () { }
            public HeightQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue data) { return new HeightQuantitativeValue (data); }
        }


        public interface IWidth : IWrapper { }
        public interface IWidth<T> : IWidth { new T Data { get; set; } }
        public class Widthstring : IWidth<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Widthstring () { }
            public Widthstring (string data) { Data = data; }
            public static implicit operator Widthstring (string data) { return new Widthstring (data); }
        }

        public class WidthQuantitativeValue : IWidth<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public WidthQuantitativeValue () { }
            public WidthQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator WidthQuantitativeValue (QuantitativeValue data) { return new WidthQuantitativeValue (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [DataMember(Name = "artEdition", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IArtEdition>? ArtEdition { get; set; } //int?, string

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IArtform>? Artform { get; set; } //string, Uri

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Artist { get; set; } 

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IArtMedium>? ArtMedium { get; set; } //string, Uri

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IArtworkSurface>? ArtworkSurface { get; set; } //string, Uri

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Colorist { get; set; } 

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IDepth>? Depth { get; set; } //string, QuantitativeValue

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHeight>? Height { get; set; } //string, QuantitativeValue

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Inker { get; set; } 

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Letterer { get; set; } 

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Penciler { get; set; } 

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IWidth>? Width { get; set; } //string, QuantitativeValue
    }
}
