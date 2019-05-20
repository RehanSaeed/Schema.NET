namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    public partial interface IMusicAlbum : IMusicPlaylist
    {
        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        OneOrMany<MusicAlbumProductionType?>? AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        OneOrMany<IMusicRelease>? AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        OneOrMany<MusicAlbumReleaseType?>? AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        Values<IMusicGroup, IPerson>? ByArtist { get; set; }
    }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    [DataContract]
    public partial class MusicAlbum : MusicPlaylist, IMusicAlbum
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicAlbum";

        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        [DataMember(Name = "albumProductionType", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MusicAlbumProductionType?>? AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        [DataMember(Name = "albumRelease", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMusicRelease>? AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        [DataMember(Name = "albumReleaseType", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MusicAlbumReleaseType?>? AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicGroup, IPerson>? ByArtist { get; set; }
    }
}
