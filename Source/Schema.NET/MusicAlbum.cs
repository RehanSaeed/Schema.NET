namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    [DataContract]
    public class MusicAlbum : MusicPlaylist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicAlbum";

        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        [DataMember(Name = "albumProductionType")]
        public MusicAlbumProductionType AlbumProductionType { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        [DataMember(Name = "albumReleaseType")]
        public MusicAlbumReleaseType AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist")]
        public MusicGroup ByArtist { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        [DataMember(Name = "albumRelease")]
        public MusicRelease AlbumRelease { get; set; }
    }
}
