namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Individual comic issues are serially published as
    ///         part of a larger series. For the sake of consistency, even one-shot issues
    ///         belong to a series comprised of a single issue. All comic issues can be
    ///         uniquely identified by: the combination of the name and volume number of the
    ///         series to which the issue belongs; the issue number; and the variant
    ///         description of the issue (if any).
    /// </summary>
    public partial interface IComicIssue : IPublicationIssue
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

        /// <summary>
        /// A description of the variant cover
        ///         for the issue, if the issue is a variant printing. For example, "Bryan Hitch
        ///         Variant Cover" or "2nd Printing Variant".
        /// </summary>
        OneOrMany<string> VariantCover { get; set; }
    }

    /// <summary>
    /// Individual comic issues are serially published as
    ///         part of a larger series. For the sake of consistency, even one-shot issues
    ///         belong to a series comprised of a single issue. All comic issues can be
    ///         uniquely identified by: the combination of the name and volume number of the
    ///         series to which the issue belongs; the issue number; and the variant
    ///         description of the issue (if any).
    /// </summary>
    [DataContract]
    public partial class ComicIssue : PublicationIssue, IComicIssue, IEquatable<ComicIssue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicIssue";

        /// <summary>
        /// The primary artist for a work
        ///         in a medium other than pencils or digital line art--for example, if the
        ///         primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Penciler { get; set; }

        /// <summary>
        /// A description of the variant cover
        ///         for the issue, if the issue is a variant printing. For example, "Bryan Hitch
        ///         Variant Cover" or "2nd Printing Variant".
        /// </summary>
        [DataMember(Name = "variantCover", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VariantCover { get; set; }

        /// <inheritdoc/>
        public bool Equals(ComicIssue other)
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
                this.VariantCover == other.VariantCover &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ComicIssue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Artist)
            .And(this.Colorist)
            .And(this.Inker)
            .And(this.Letterer)
            .And(this.Penciler)
            .And(this.VariantCover)
            .And(base.GetHashCode());
    }
}
