namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// </summary>
    public enum MusicAlbumProductionType
    {
        /// <summary>
        /// CompilationAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CompilationAlbum")]
        CompilationAlbum,

        /// <summary>
        /// DemoAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DemoAlbum")]
        DemoAlbum,

        /// <summary>
        /// DJMixAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DJMixAlbum")]
        DJMixAlbum,

        /// <summary>
        /// LiveAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/LiveAlbum")]
        LiveAlbum,

        /// <summary>
        /// MixtapeAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MixtapeAlbum")]
        MixtapeAlbum,

        /// <summary>
        /// RemixAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RemixAlbum")]
        RemixAlbum,

        /// <summary>
        /// SoundtrackAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SoundtrackAlbum")]
        SoundtrackAlbum,

        /// <summary>
        /// SpokenWordAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SpokenWordAlbum")]
        SpokenWordAlbum,

        /// <summary>
        /// StudioAlbum.
        /// </summary>
        [EnumMember(Value = "http://schema.org/StudioAlbum")]
        StudioAlbum
    }
}
