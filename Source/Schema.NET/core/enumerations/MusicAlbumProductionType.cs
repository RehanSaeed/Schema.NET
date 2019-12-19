namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicAlbumProductionType
    {
        /// <summary>
        /// CompilationAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CompilationAlbum")]
        CompilationAlbum,

        /// <summary>
        /// DemoAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DemoAlbum")]
        DemoAlbum,

        /// <summary>
        /// DJMixAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DJMixAlbum")]
        DJMixAlbum,

        /// <summary>
        /// LiveAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LiveAlbum")]
        LiveAlbum,

        /// <summary>
        /// MixtapeAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/MixtapeAlbum")]
        MixtapeAlbum,

        /// <summary>
        /// RemixAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RemixAlbum")]
        RemixAlbum,

        /// <summary>
        /// SoundtrackAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SoundtrackAlbum")]
        SoundtrackAlbum,

        /// <summary>
        /// SpokenWordAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SpokenWordAlbum")]
        SpokenWordAlbum,

        /// <summary>
        /// StudioAlbum.
        /// </summary>
        [EnumMember(Value = "https://schema.org/StudioAlbum")]
        StudioAlbum,
    }
}
