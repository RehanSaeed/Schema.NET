namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See ComicStory, CoverArt for more information.
    /// </summary>
    public partial interface IComicStoryAndCoverArt : IComicStory, ICoverArt
    {
    }

    /// <summary>
    /// See ComicStory, CoverArt for more information.
    /// </summary>
    [DataContract]
    public abstract partial class ComicStoryAndCoverArt : VisualArtwork, IComicStoryAndCoverArt, IEquatable<ComicStoryAndCoverArt>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicStoryAndCoverArt";

        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Penciler { get; set; }

        /// <inheritdoc/>
        public bool Equals(ComicStoryAndCoverArt other)
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
                this.Artist == other.Artist &&
                this.Colorist == other.Colorist &&
                this.Inker == other.Inker &&
                this.Letterer == other.Letterer &&
                this.Penciler == other.Penciler &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ComicStoryAndCoverArt);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Artist)
            .And(this.Colorist)
            .And(this.Inker)
            .And(this.Letterer)
            .And(this.Penciler)
            .And(base.GetHashCode());
    }
}
