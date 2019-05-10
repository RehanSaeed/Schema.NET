namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public partial interface IComicStory : ICreativeWork
    {
        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        OneOrMany<IPerson>? Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        OneOrMany<IPerson>? Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        OneOrMany<IPerson>? Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        OneOrMany<IPerson>? Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        OneOrMany<IPerson>? Penciler { get; set; }
    }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    [DataContract]
    public partial class ComicStory : CreativeWork, IComicStory
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicStory";

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Penciler { get; set; }
    }
}
