namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public class VisualArtwork : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height")]
        public object Height { get; protected set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance HeightDistance
        {
            get => this.Height as Distance;
            set => this.Height = value;
        }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue HeightQuantitativeValue
        {
            get => this.Height as QuantitativeValue;
            set => this.Height = value;
        }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium")]
        public object ArtMedium { get; protected set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [IgnoreDataMember]
        public Uri ArtMediumURL
        {
            get => this.ArtMedium as Uri;
            set => this.ArtMedium = value;
        }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [IgnoreDataMember]
        public string ArtMediumText
        {
            get => this.ArtMedium as string;
            set => this.ArtMedium = value;
        }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform")]
        public object Artform { get; protected set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [IgnoreDataMember]
        public string ArtformText
        {
            get => this.Artform as string;
            set => this.Artform = value;
        }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [IgnoreDataMember]
        public Uri ArtformURL
        {
            get => this.Artform as Uri;
            set => this.Artform = value;
        }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface")]
        public object ArtworkSurface { get; protected set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [IgnoreDataMember]
        public string ArtworkSurfaceText
        {
            get => this.ArtworkSurface as string;
            set => this.ArtworkSurface = value;
        }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [IgnoreDataMember]
        public Uri ArtworkSurfaceURL
        {
            get => this.ArtworkSurface as Uri;
            set => this.ArtworkSurface = value;
        }

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [DataMember(Name = "artEdition")]
        public object ArtEdition { get; protected set; }

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [IgnoreDataMember]
        public string ArtEditionText
        {
            get => this.ArtEdition as string;
            set => this.ArtEdition = value;
        }

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [IgnoreDataMember]
        public int? ArtEditionInteger
        {
            get => this.ArtEdition as int?;
            set => this.ArtEdition = value;
        }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width")]
        public object Width { get; protected set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance WidthDistance
        {
            get => this.Width as Distance;
            set => this.Width = value;
        }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue WidthQuantitativeValue
        {
            get => this.Width as QuantitativeValue;
            set => this.Width = value;
        }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth")]
        public object Depth { get; protected set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance DepthDistance
        {
            get => this.Depth as Distance;
            set => this.Depth = value;
        }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue DepthQuantitativeValue
        {
            get => this.Depth as QuantitativeValue;
            set => this.Depth = value;
        }
    }
}
