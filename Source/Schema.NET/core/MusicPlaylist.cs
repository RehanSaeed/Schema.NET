namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    [DataContract]
    public partial class MusicPlaylist : CreativeWork
    {
        public interface INumTracks : IValue {}
        public interface INumTracks<T> : INumTracks { new T Value { get; } }
        public class OneOrManyNumTracks : OneOrMany<INumTracks>
        {
            public OneOrManyNumTracks(INumTracks item) : base(item) { }
            public OneOrManyNumTracks(IEnumerable<INumTracks> items) : base(items) { }
            public static implicit operator OneOrManyNumTracks (int value) { return new OneOrManyNumTracks (new NumTracksint (value)); }
            public static implicit operator OneOrManyNumTracks (int[] values) { return new OneOrManyNumTracks (values.Select(v => (INumTracks) new NumTracksint (v))); }
            public static implicit operator OneOrManyNumTracks (List<int> values) { return new OneOrManyNumTracks (values.Select(v => (INumTracks) new NumTracksint (v))); }
        }
        public struct NumTracksint : INumTracks<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumTracksint (int value) { Value = value; }
            public static implicit operator NumTracksint (int value) { return new NumTracksint (value); }
        }

        public interface ITrack : IValue {}
        public interface ITrack<T> : ITrack { new T Value { get; } }
        public class OneOrManyTrack : OneOrMany<ITrack>
        {
            public OneOrManyTrack(ITrack item) : base(item) { }
            public OneOrManyTrack(IEnumerable<ITrack> items) : base(items) { }
            public static implicit operator OneOrManyTrack (ItemList value) { return new OneOrManyTrack (new TrackItemList (value)); }
            public static implicit operator OneOrManyTrack (ItemList[] values) { return new OneOrManyTrack (values.Select(v => (ITrack) new TrackItemList (v))); }
            public static implicit operator OneOrManyTrack (List<ItemList> values) { return new OneOrManyTrack (values.Select(v => (ITrack) new TrackItemList (v))); }
            public static implicit operator OneOrManyTrack (MusicRecording value) { return new OneOrManyTrack (new TrackMusicRecording (value)); }
            public static implicit operator OneOrManyTrack (MusicRecording[] values) { return new OneOrManyTrack (values.Select(v => (ITrack) new TrackMusicRecording (v))); }
            public static implicit operator OneOrManyTrack (List<MusicRecording> values) { return new OneOrManyTrack (values.Select(v => (ITrack) new TrackMusicRecording (v))); }
        }
        public struct TrackItemList : ITrack<ItemList>
        {
            object IValue.Value => this.Value;
            public ItemList Value { get; }
            public TrackItemList (ItemList value) { Value = value; }
            public static implicit operator TrackItemList (ItemList value) { return new TrackItemList (value); }
        }
        public struct TrackMusicRecording : ITrack<MusicRecording>
        {
            object IValue.Value => this.Value;
            public MusicRecording Value { get; }
            public TrackMusicRecording (MusicRecording value) { Value = value; }
            public static implicit operator TrackMusicRecording (MusicRecording value) { return new TrackMusicRecording (value); }
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
        public OneOrManyNumTracks NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track", Order = 207)]
        public OneOrManyTrack Track { get; set; }
    }
}
