using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    [DataContract]
    public partial class MusicGroup : PerformingGroup
    {
        public interface IGenre : IWrapper { }
        public interface IGenre<T> : IGenre { new T Data { get; set; } }
        public class Genrestring : IGenre<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Genrestring () { }
            public Genrestring (string data) { Data = data; }
            public static implicit operator Genrestring (string data) { return new Genrestring (data); }
        }

        public class GenreUri : IGenre<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public GenreUri () { }
            public GenreUri (Uri data) { Data = data; }
            public static implicit operator GenreUri (Uri data) { return new GenreUri (data); }
        }


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
        public override string Type => "MusicGroup";

        /// <summary>
        /// A music album.
        /// </summary>
        [DataMember(Name = "album", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicAlbum>? Album { get; set; } 

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGenre>? Genre { get; set; } //string, Uri

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITrack>? Track { get; set; } //ItemList, MusicRecording
    }
}
