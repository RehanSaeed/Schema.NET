namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    public partial interface IVisualArtwork : ICreativeWork
    {
        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        Values<int?, string> ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        Values<string, Uri> Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        Values<string, Uri> ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        Values<string, Uri> ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        OneOrMany<IPerson> Penciler { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Width { get; set; }
    }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public partial class VisualArtwork : CreativeWork, IVisualArtwork, IEquatable<VisualArtwork>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [DataMember(Name = "artEdition", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Penciler { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Width { get; set; }

        /// <inheritdoc/>
        public bool Equals(VisualArtwork other)
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
                this.ArtEdition == other.ArtEdition &&
                this.Artform == other.Artform &&
                this.Artist == other.Artist &&
                this.ArtMedium == other.ArtMedium &&
                this.ArtworkSurface == other.ArtworkSurface &&
                this.Colorist == other.Colorist &&
                this.Depth == other.Depth &&
                this.Height == other.Height &&
                this.Inker == other.Inker &&
                this.Letterer == other.Letterer &&
                this.Penciler == other.Penciler &&
                this.Width == other.Width &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as VisualArtwork);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ArtEdition)
            .And(this.Artform)
            .And(this.Artist)
            .And(this.ArtMedium)
            .And(this.ArtworkSurface)
            .And(this.Colorist)
            .And(this.Depth)
            .And(this.Height)
            .And(this.Inker)
            .And(this.Letterer)
            .And(this.Penciler)
            .And(this.Width)
            .And(base.GetHashCode());
    }
}
