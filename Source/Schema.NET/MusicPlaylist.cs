namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    [DataContract]
    public class MusicPlaylist : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicPlaylist";

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track")]
        public object Track { get; protected set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [IgnoreDataMember]
        public MusicRecording TrackMusicRecording
        {
            get => this.Track as MusicRecording;
            set => this.Track = value;
        }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [IgnoreDataMember]
        public ItemList TrackItemList
        {
            get => this.Track as ItemList;
            set => this.Track = value;
        }

        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        [DataMember(Name = "numTracks")]
        public int NumTracks { get; set; }
    }
}
