namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    public partial interface IMusicPlaylist : ICreativeWork
    {
        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        OneOrMany<int?>? NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        Values<IItemList, IMusicRecording>? Track { get; set; }
    }

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    [DataContract]
    public partial class MusicPlaylist : CreativeWork, IMusicPlaylist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicPlaylist";

        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        [DataMember(Name = "numTracks", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IItemList, IMusicRecording>? Track { get; set; }
    }
}
