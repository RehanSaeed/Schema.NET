namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public partial class VisualArtwork : CreativeWork
    {
        public interface IArtEdition : IValue {}
        public interface IArtEdition<T> : IArtEdition { new T Value { get; } }
        public class OneOrManyArtEdition : OneOrMany<IArtEdition>
        {
            public OneOrManyArtEdition(IArtEdition item) : base(item) { }
            public OneOrManyArtEdition(IEnumerable<IArtEdition> items) : base(items) { }
            public static implicit operator OneOrManyArtEdition (int value) { return new OneOrManyArtEdition (new ArtEditionint (value)); }
            public static implicit operator OneOrManyArtEdition (int[] values) { return new OneOrManyArtEdition (values.Select(v => (IArtEdition) new ArtEditionint (v))); }
            public static implicit operator OneOrManyArtEdition (List<int> values) { return new OneOrManyArtEdition (values.Select(v => (IArtEdition) new ArtEditionint (v))); }
            public static implicit operator OneOrManyArtEdition (string value) { return new OneOrManyArtEdition (new ArtEditionstring (value)); }
            public static implicit operator OneOrManyArtEdition (string[] values) { return new OneOrManyArtEdition (values.Select(v => (IArtEdition) new ArtEditionstring (v))); }
            public static implicit operator OneOrManyArtEdition (List<string> values) { return new OneOrManyArtEdition (values.Select(v => (IArtEdition) new ArtEditionstring (v))); }
        }
        public struct ArtEditionint : IArtEdition<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ArtEditionint (int value) { Value = value; }
            public static implicit operator ArtEditionint (int value) { return new ArtEditionint (value); }
        }
        public struct ArtEditionstring : IArtEdition<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArtEditionstring (string value) { Value = value; }
            public static implicit operator ArtEditionstring (string value) { return new ArtEditionstring (value); }
        }

        public interface IArtform : IValue {}
        public interface IArtform<T> : IArtform { new T Value { get; } }
        public class OneOrManyArtform : OneOrMany<IArtform>
        {
            public OneOrManyArtform(IArtform item) : base(item) { }
            public OneOrManyArtform(IEnumerable<IArtform> items) : base(items) { }
            public static implicit operator OneOrManyArtform (string value) { return new OneOrManyArtform (new Artformstring (value)); }
            public static implicit operator OneOrManyArtform (string[] values) { return new OneOrManyArtform (values.Select(v => (IArtform) new Artformstring (v))); }
            public static implicit operator OneOrManyArtform (List<string> values) { return new OneOrManyArtform (values.Select(v => (IArtform) new Artformstring (v))); }
            public static implicit operator OneOrManyArtform (Uri value) { return new OneOrManyArtform (new ArtformUri (value)); }
            public static implicit operator OneOrManyArtform (Uri[] values) { return new OneOrManyArtform (values.Select(v => (IArtform) new ArtformUri (v))); }
            public static implicit operator OneOrManyArtform (List<Uri> values) { return new OneOrManyArtform (values.Select(v => (IArtform) new ArtformUri (v))); }
        }
        public struct Artformstring : IArtform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Artformstring (string value) { Value = value; }
            public static implicit operator Artformstring (string value) { return new Artformstring (value); }
        }
        public struct ArtformUri : IArtform<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ArtformUri (Uri value) { Value = value; }
            public static implicit operator ArtformUri (Uri value) { return new ArtformUri (value); }
        }

        public interface IArtist : IValue {}
        public interface IArtist<T> : IArtist { new T Value { get; } }
        public class OneOrManyArtist : OneOrMany<IArtist>
        {
            public OneOrManyArtist(IArtist item) : base(item) { }
            public OneOrManyArtist(IEnumerable<IArtist> items) : base(items) { }
            public static implicit operator OneOrManyArtist (Person value) { return new OneOrManyArtist (new ArtistPerson (value)); }
            public static implicit operator OneOrManyArtist (Person[] values) { return new OneOrManyArtist (values.Select(v => (IArtist) new ArtistPerson (v))); }
            public static implicit operator OneOrManyArtist (List<Person> values) { return new OneOrManyArtist (values.Select(v => (IArtist) new ArtistPerson (v))); }
        }
        public struct ArtistPerson : IArtist<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ArtistPerson (Person value) { Value = value; }
            public static implicit operator ArtistPerson (Person value) { return new ArtistPerson (value); }
        }

        public interface IArtMedium : IValue {}
        public interface IArtMedium<T> : IArtMedium { new T Value { get; } }
        public class OneOrManyArtMedium : OneOrMany<IArtMedium>
        {
            public OneOrManyArtMedium(IArtMedium item) : base(item) { }
            public OneOrManyArtMedium(IEnumerable<IArtMedium> items) : base(items) { }
            public static implicit operator OneOrManyArtMedium (string value) { return new OneOrManyArtMedium (new ArtMediumstring (value)); }
            public static implicit operator OneOrManyArtMedium (string[] values) { return new OneOrManyArtMedium (values.Select(v => (IArtMedium) new ArtMediumstring (v))); }
            public static implicit operator OneOrManyArtMedium (List<string> values) { return new OneOrManyArtMedium (values.Select(v => (IArtMedium) new ArtMediumstring (v))); }
            public static implicit operator OneOrManyArtMedium (Uri value) { return new OneOrManyArtMedium (new ArtMediumUri (value)); }
            public static implicit operator OneOrManyArtMedium (Uri[] values) { return new OneOrManyArtMedium (values.Select(v => (IArtMedium) new ArtMediumUri (v))); }
            public static implicit operator OneOrManyArtMedium (List<Uri> values) { return new OneOrManyArtMedium (values.Select(v => (IArtMedium) new ArtMediumUri (v))); }
        }
        public struct ArtMediumstring : IArtMedium<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArtMediumstring (string value) { Value = value; }
            public static implicit operator ArtMediumstring (string value) { return new ArtMediumstring (value); }
        }
        public struct ArtMediumUri : IArtMedium<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ArtMediumUri (Uri value) { Value = value; }
            public static implicit operator ArtMediumUri (Uri value) { return new ArtMediumUri (value); }
        }

        public interface IArtworkSurface : IValue {}
        public interface IArtworkSurface<T> : IArtworkSurface { new T Value { get; } }
        public class OneOrManyArtworkSurface : OneOrMany<IArtworkSurface>
        {
            public OneOrManyArtworkSurface(IArtworkSurface item) : base(item) { }
            public OneOrManyArtworkSurface(IEnumerable<IArtworkSurface> items) : base(items) { }
            public static implicit operator OneOrManyArtworkSurface (string value) { return new OneOrManyArtworkSurface (new ArtworkSurfacestring (value)); }
            public static implicit operator OneOrManyArtworkSurface (string[] values) { return new OneOrManyArtworkSurface (values.Select(v => (IArtworkSurface) new ArtworkSurfacestring (v))); }
            public static implicit operator OneOrManyArtworkSurface (List<string> values) { return new OneOrManyArtworkSurface (values.Select(v => (IArtworkSurface) new ArtworkSurfacestring (v))); }
            public static implicit operator OneOrManyArtworkSurface (Uri value) { return new OneOrManyArtworkSurface (new ArtworkSurfaceUri (value)); }
            public static implicit operator OneOrManyArtworkSurface (Uri[] values) { return new OneOrManyArtworkSurface (values.Select(v => (IArtworkSurface) new ArtworkSurfaceUri (v))); }
            public static implicit operator OneOrManyArtworkSurface (List<Uri> values) { return new OneOrManyArtworkSurface (values.Select(v => (IArtworkSurface) new ArtworkSurfaceUri (v))); }
        }
        public struct ArtworkSurfacestring : IArtworkSurface<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArtworkSurfacestring (string value) { Value = value; }
            public static implicit operator ArtworkSurfacestring (string value) { return new ArtworkSurfacestring (value); }
        }
        public struct ArtworkSurfaceUri : IArtworkSurface<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ArtworkSurfaceUri (Uri value) { Value = value; }
            public static implicit operator ArtworkSurfaceUri (Uri value) { return new ArtworkSurfaceUri (value); }
        }

        public interface IColorist : IValue {}
        public interface IColorist<T> : IColorist { new T Value { get; } }
        public class OneOrManyColorist : OneOrMany<IColorist>
        {
            public OneOrManyColorist(IColorist item) : base(item) { }
            public OneOrManyColorist(IEnumerable<IColorist> items) : base(items) { }
            public static implicit operator OneOrManyColorist (Person value) { return new OneOrManyColorist (new ColoristPerson (value)); }
            public static implicit operator OneOrManyColorist (Person[] values) { return new OneOrManyColorist (values.Select(v => (IColorist) new ColoristPerson (v))); }
            public static implicit operator OneOrManyColorist (List<Person> values) { return new OneOrManyColorist (values.Select(v => (IColorist) new ColoristPerson (v))); }
        }
        public struct ColoristPerson : IColorist<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ColoristPerson (Person value) { Value = value; }
            public static implicit operator ColoristPerson (Person value) { return new ColoristPerson (value); }
        }

        public interface IDepth : IValue {}
        public interface IDepth<T> : IDepth { new T Value { get; } }
        public class OneOrManyDepth : OneOrMany<IDepth>
        {
            public OneOrManyDepth(IDepth item) : base(item) { }
            public OneOrManyDepth(IEnumerable<IDepth> items) : base(items) { }
            public static implicit operator OneOrManyDepth (string value) { return new OneOrManyDepth (new Depthstring (value)); }
            public static implicit operator OneOrManyDepth (string[] values) { return new OneOrManyDepth (values.Select(v => (IDepth) new Depthstring (v))); }
            public static implicit operator OneOrManyDepth (List<string> values) { return new OneOrManyDepth (values.Select(v => (IDepth) new Depthstring (v))); }
            public static implicit operator OneOrManyDepth (QuantitativeValue value) { return new OneOrManyDepth (new DepthQuantitativeValue (value)); }
            public static implicit operator OneOrManyDepth (QuantitativeValue[] values) { return new OneOrManyDepth (values.Select(v => (IDepth) new DepthQuantitativeValue (v))); }
            public static implicit operator OneOrManyDepth (List<QuantitativeValue> values) { return new OneOrManyDepth (values.Select(v => (IDepth) new DepthQuantitativeValue (v))); }
        }
        public struct Depthstring : IDepth<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Depthstring (string value) { Value = value; }
            public static implicit operator Depthstring (string value) { return new Depthstring (value); }
        }
        public struct DepthQuantitativeValue : IDepth<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public DepthQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator DepthQuantitativeValue (QuantitativeValue value) { return new DepthQuantitativeValue (value); }
        }

        public interface IHeight : IValue {}
        public interface IHeight<T> : IHeight { new T Value { get; } }
        public class OneOrManyHeight : OneOrMany<IHeight>
        {
            public OneOrManyHeight(IHeight item) : base(item) { }
            public OneOrManyHeight(IEnumerable<IHeight> items) : base(items) { }
            public static implicit operator OneOrManyHeight (string value) { return new OneOrManyHeight (new Heightstring (value)); }
            public static implicit operator OneOrManyHeight (string[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (List<string> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (QuantitativeValue value) { return new OneOrManyHeight (new HeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyHeight (QuantitativeValue[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyHeight (List<QuantitativeValue> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
        }
        public struct Heightstring : IHeight<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Heightstring (string value) { Value = value; }
            public static implicit operator Heightstring (string value) { return new Heightstring (value); }
        }
        public struct HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public HeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue value) { return new HeightQuantitativeValue (value); }
        }

        public interface IInker : IValue {}
        public interface IInker<T> : IInker { new T Value { get; } }
        public class OneOrManyInker : OneOrMany<IInker>
        {
            public OneOrManyInker(IInker item) : base(item) { }
            public OneOrManyInker(IEnumerable<IInker> items) : base(items) { }
            public static implicit operator OneOrManyInker (Person value) { return new OneOrManyInker (new InkerPerson (value)); }
            public static implicit operator OneOrManyInker (Person[] values) { return new OneOrManyInker (values.Select(v => (IInker) new InkerPerson (v))); }
            public static implicit operator OneOrManyInker (List<Person> values) { return new OneOrManyInker (values.Select(v => (IInker) new InkerPerson (v))); }
        }
        public struct InkerPerson : IInker<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public InkerPerson (Person value) { Value = value; }
            public static implicit operator InkerPerson (Person value) { return new InkerPerson (value); }
        }

        public interface ILetterer : IValue {}
        public interface ILetterer<T> : ILetterer { new T Value { get; } }
        public class OneOrManyLetterer : OneOrMany<ILetterer>
        {
            public OneOrManyLetterer(ILetterer item) : base(item) { }
            public OneOrManyLetterer(IEnumerable<ILetterer> items) : base(items) { }
            public static implicit operator OneOrManyLetterer (Person value) { return new OneOrManyLetterer (new LettererPerson (value)); }
            public static implicit operator OneOrManyLetterer (Person[] values) { return new OneOrManyLetterer (values.Select(v => (ILetterer) new LettererPerson (v))); }
            public static implicit operator OneOrManyLetterer (List<Person> values) { return new OneOrManyLetterer (values.Select(v => (ILetterer) new LettererPerson (v))); }
        }
        public struct LettererPerson : ILetterer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LettererPerson (Person value) { Value = value; }
            public static implicit operator LettererPerson (Person value) { return new LettererPerson (value); }
        }

        public interface IPenciler : IValue {}
        public interface IPenciler<T> : IPenciler { new T Value { get; } }
        public class OneOrManyPenciler : OneOrMany<IPenciler>
        {
            public OneOrManyPenciler(IPenciler item) : base(item) { }
            public OneOrManyPenciler(IEnumerable<IPenciler> items) : base(items) { }
            public static implicit operator OneOrManyPenciler (Person value) { return new OneOrManyPenciler (new PencilerPerson (value)); }
            public static implicit operator OneOrManyPenciler (Person[] values) { return new OneOrManyPenciler (values.Select(v => (IPenciler) new PencilerPerson (v))); }
            public static implicit operator OneOrManyPenciler (List<Person> values) { return new OneOrManyPenciler (values.Select(v => (IPenciler) new PencilerPerson (v))); }
        }
        public struct PencilerPerson : IPenciler<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public PencilerPerson (Person value) { Value = value; }
            public static implicit operator PencilerPerson (Person value) { return new PencilerPerson (value); }
        }

        public interface IWidth : IValue {}
        public interface IWidth<T> : IWidth { new T Value { get; } }
        public class OneOrManyWidth : OneOrMany<IWidth>
        {
            public OneOrManyWidth(IWidth item) : base(item) { }
            public OneOrManyWidth(IEnumerable<IWidth> items) : base(items) { }
            public static implicit operator OneOrManyWidth (string value) { return new OneOrManyWidth (new Widthstring (value)); }
            public static implicit operator OneOrManyWidth (string[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (List<string> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (QuantitativeValue value) { return new OneOrManyWidth (new WidthQuantitativeValue (value)); }
            public static implicit operator OneOrManyWidth (QuantitativeValue[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
            public static implicit operator OneOrManyWidth (List<QuantitativeValue> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
        }
        public struct Widthstring : IWidth<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Widthstring (string value) { Value = value; }
            public static implicit operator Widthstring (string value) { return new Widthstring (value); }
        }
        public struct WidthQuantitativeValue : IWidth<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WidthQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WidthQuantitativeValue (QuantitativeValue value) { return new WidthQuantitativeValue (value); }
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
        public OneOrManyArtEdition ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform", Order = 207)]
        public OneOrManyArtform Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 208)]
        public virtual OneOrManyArtist Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium", Order = 209)]
        public OneOrManyArtMedium ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface", Order = 210)]
        public OneOrManyArtworkSurface ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 211)]
        public virtual OneOrManyColorist Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 212)]
        public OneOrManyDepth Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 213)]
        public OneOrManyHeight Height { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 214)]
        public virtual OneOrManyInker Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 215)]
        public virtual OneOrManyLetterer Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 216)]
        public virtual OneOrManyPenciler Penciler { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 217)]
        public OneOrManyWidth Width { get; set; }
    }
}
