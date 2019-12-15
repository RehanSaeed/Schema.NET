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
        OneOrMany<MusicAlbumProductionType?> AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        OneOrMany<IMusicRelease> AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        OneOrMany<MusicAlbumReleaseType?> AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        Values<IMusicGroup, IPerson> ByArtist { get; set; }
    }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    [DataContract]
    public partial class MusicAlbum : MusicPlaylist, IMusicAlbum, IEquatable<MusicAlbum>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicAlbumProductionType?> AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        [DataMember(Name = "albumRelease", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicRelease> AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        [DataMember(Name = "albumReleaseType", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicAlbumReleaseType?> AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> ByArtist { get; set; }

        /// <inheritdoc/>
        public bool Equals(MusicAlbum other)
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
                this.AlbumProductionType == other.AlbumProductionType &&
                this.AlbumRelease == other.AlbumRelease &&
                this.AlbumReleaseType == other.AlbumReleaseType &&
                this.ByArtist == other.ByArtist &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MusicAlbum);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AlbumProductionType)
            .And(this.AlbumRelease)
            .And(this.AlbumReleaseType)
            .And(this.ByArtist)
            .And(base.GetHashCode());
    }
}
