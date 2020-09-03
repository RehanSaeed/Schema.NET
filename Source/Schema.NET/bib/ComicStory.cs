namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///         unit of a comic, including the interior stories, covers, and backmatter. Most
    ///         comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public partial interface IComicStory : ICreativeWork
    {
        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        OneOrMany<IPerson> Colorist { get; set; }

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
    }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///         unit of a comic, including the interior stories, covers, and backmatter. Most
    ///         comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    [DataContract]
    public partial class ComicStory : CreativeWork, IComicStory, IEquatable<ComicStory>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicStory";

        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Penciler { get; set; }

        /// <inheritdoc/>
        public bool Equals(ComicStory other)
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
        public override bool Equals(object obj) => this.Equals(obj as ComicStory);

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
