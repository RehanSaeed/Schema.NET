namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    [DataContract]
    public partial class MusicRecording : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRecording";

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicGroup>? ByArtist { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 205)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inAlbum", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicAlbum>? InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inPlaylist", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicPlaylist>? InPlaylist { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        [DataMember(Name = "isrcCode", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IsrcCode { get; set; }

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        [DataMember(Name = "recordingOf", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicComposition>? RecordingOf { get; set; }
    }
}
