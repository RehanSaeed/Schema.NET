namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    [DataContract]
    public class MusicGroup : PerformingGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicGroup";

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
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre")]
        public object Genre { get; protected set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [IgnoreDataMember]
        public string GenreText
        {
            get => this.Genre as string;
            set => this.Genre = value;
        }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [IgnoreDataMember]
        public Uri GenreURL
        {
            get => this.Genre as Uri;
            set => this.Genre = value;
        }

        /// <summary>
        /// A music album.
        /// </summary>
        [DataMember(Name = "album")]
        public MusicAlbum Album { get; set; }
    }
}
