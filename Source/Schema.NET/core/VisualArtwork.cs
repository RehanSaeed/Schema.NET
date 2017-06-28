namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public partial class VisualArtwork : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [DataMember(Name = "artEdition", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, int?>? ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? Artform { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, string>? ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ArtworkSurface { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue>? Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue, int?>? Height { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue, int?>? Width { get; set; }
    }
}
