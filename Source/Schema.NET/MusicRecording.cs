namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    [DataContract]
    public class MusicRecording : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicRecording";

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        [DataMember(Name = "recordingOf")]
        public MusicComposition RecordingOf { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        [DataMember(Name = "isrcCode")]
        public string IsrcCode { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inAlbum")]
        public MusicAlbum InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inPlaylist")]
        public MusicPlaylist InPlaylist { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist")]
        public MusicGroup ByArtist { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration")]
        public Duration Duration { get; set; }
    }
}
