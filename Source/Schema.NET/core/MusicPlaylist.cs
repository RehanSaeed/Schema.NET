using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    [DataContract]
    public partial class MusicPlaylist : CreativeWork
    {
        public interface ITrack : IWrapper { }
        public interface ITrack<T> : ITrack { new T Data { get; set; } }
        public class TrackItemList : ITrack<ItemList>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ItemList) value; } }
            public virtual ItemList Data { get; set; }
            public TrackItemList () { }
            public TrackItemList (ItemList data) { Data = data; }
            public static implicit operator TrackItemList (ItemList data) { return new TrackItemList (data); }
        }

        public class TrackMusicRecording : ITrack<MusicRecording>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MusicRecording) value; } }
            public virtual MusicRecording Data { get; set; }
            public TrackMusicRecording () { }
            public TrackMusicRecording (MusicRecording data) { Data = data; }
            public static implicit operator TrackMusicRecording (MusicRecording data) { return new TrackMusicRecording (data); }
        }


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
        public Values<int>? NumTracks { get; set; } 

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITrack>? Track { get; set; } //ItemList, MusicRecording
    }
}
