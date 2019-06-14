namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    public partial interface IMusicRelease : IMusicPlaylist
    {
        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        OneOrMany<string> CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        Values<IOrganization, IPerson>? CreditedTo { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        OneOrMany<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        OneOrMany<IOrganization, Organization> RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        OneOrMany<IMusicAlbum, MusicAlbum> ReleaseOf { get; set; }
    }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    [DataContract]
    public partial class MusicRelease : MusicPlaylist, IMusicRelease
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRelease";

        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        [DataMember(Name = "catalogNumber", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [DataMember(Name = "creditedTo", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson>? CreditedTo { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 308)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        [DataMember(Name = "recordLabel", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization, Organization> RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        [DataMember(Name = "releaseOf", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicAlbum, MusicAlbum> ReleaseOf { get; set; }
    }
}
