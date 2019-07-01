namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicAlbumReleaseType
    {
        /// <summary>
        /// AlbumRelease.
        /// </summary>
        [EnumMember(Value = "http://schema.org/AlbumRelease")]
        AlbumRelease,

        /// <summary>
        /// BroadcastRelease.
        /// </summary>
        [EnumMember(Value = "http://schema.org/BroadcastRelease")]
        BroadcastRelease,

        /// <summary>
        /// EPRelease.
        /// </summary>
        [EnumMember(Value = "http://schema.org/EPRelease")]
        EPRelease,

        /// <summary>
        /// SingleRelease.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SingleRelease")]
        SingleRelease
    }
}
