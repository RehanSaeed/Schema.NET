namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    [DataContract]
    public partial class MusicRecording : CreativeWork
    {
        public interface IByArtist : IValue {}
        public interface IByArtist<T> : IByArtist { new T Value { get; } }
        public class OneOrManyByArtist : OneOrMany<IByArtist>
        {
            public OneOrManyByArtist(IByArtist item) : base(item) { }
            public OneOrManyByArtist(IEnumerable<IByArtist> items) : base(items) { }
            public static implicit operator OneOrManyByArtist (MusicGroup value) { return new OneOrManyByArtist (new ByArtistMusicGroup (value)); }
            public static implicit operator OneOrManyByArtist (MusicGroup[] values) { return new OneOrManyByArtist (values.Select(v => (IByArtist) new ByArtistMusicGroup (v))); }
            public static implicit operator OneOrManyByArtist (List<MusicGroup> values) { return new OneOrManyByArtist (values.Select(v => (IByArtist) new ByArtistMusicGroup (v))); }
        }
        public struct ByArtistMusicGroup : IByArtist<MusicGroup>
        {
            object IValue.Value => this.Value;
            public MusicGroup Value { get; }
            public ByArtistMusicGroup (MusicGroup value) { Value = value; }
            public static implicit operator ByArtistMusicGroup (MusicGroup value) { return new ByArtistMusicGroup (value); }
        }

        public interface IDuration : IValue {}
        public interface IDuration<T> : IDuration { new T Value { get; } }
        public class OneOrManyDuration : OneOrMany<IDuration>
        {
            public OneOrManyDuration(IDuration item) : base(item) { }
            public OneOrManyDuration(IEnumerable<IDuration> items) : base(items) { }
            public static implicit operator OneOrManyDuration (TimeSpan value) { return new OneOrManyDuration (new DurationTimeSpan (value)); }
            public static implicit operator OneOrManyDuration (TimeSpan[] values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
            public static implicit operator OneOrManyDuration (List<TimeSpan> values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
        }
        public struct DurationTimeSpan : IDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public DurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator DurationTimeSpan (TimeSpan value) { return new DurationTimeSpan (value); }
        }

        public interface IInAlbum : IValue {}
        public interface IInAlbum<T> : IInAlbum { new T Value { get; } }
        public class OneOrManyInAlbum : OneOrMany<IInAlbum>
        {
            public OneOrManyInAlbum(IInAlbum item) : base(item) { }
            public OneOrManyInAlbum(IEnumerable<IInAlbum> items) : base(items) { }
            public static implicit operator OneOrManyInAlbum (MusicAlbum value) { return new OneOrManyInAlbum (new InAlbumMusicAlbum (value)); }
            public static implicit operator OneOrManyInAlbum (MusicAlbum[] values) { return new OneOrManyInAlbum (values.Select(v => (IInAlbum) new InAlbumMusicAlbum (v))); }
            public static implicit operator OneOrManyInAlbum (List<MusicAlbum> values) { return new OneOrManyInAlbum (values.Select(v => (IInAlbum) new InAlbumMusicAlbum (v))); }
        }
        public struct InAlbumMusicAlbum : IInAlbum<MusicAlbum>
        {
            object IValue.Value => this.Value;
            public MusicAlbum Value { get; }
            public InAlbumMusicAlbum (MusicAlbum value) { Value = value; }
            public static implicit operator InAlbumMusicAlbum (MusicAlbum value) { return new InAlbumMusicAlbum (value); }
        }

        public interface IInPlaylist : IValue {}
        public interface IInPlaylist<T> : IInPlaylist { new T Value { get; } }
        public class OneOrManyInPlaylist : OneOrMany<IInPlaylist>
        {
            public OneOrManyInPlaylist(IInPlaylist item) : base(item) { }
            public OneOrManyInPlaylist(IEnumerable<IInPlaylist> items) : base(items) { }
            public static implicit operator OneOrManyInPlaylist (MusicPlaylist value) { return new OneOrManyInPlaylist (new InPlaylistMusicPlaylist (value)); }
            public static implicit operator OneOrManyInPlaylist (MusicPlaylist[] values) { return new OneOrManyInPlaylist (values.Select(v => (IInPlaylist) new InPlaylistMusicPlaylist (v))); }
            public static implicit operator OneOrManyInPlaylist (List<MusicPlaylist> values) { return new OneOrManyInPlaylist (values.Select(v => (IInPlaylist) new InPlaylistMusicPlaylist (v))); }
        }
        public struct InPlaylistMusicPlaylist : IInPlaylist<MusicPlaylist>
        {
            object IValue.Value => this.Value;
            public MusicPlaylist Value { get; }
            public InPlaylistMusicPlaylist (MusicPlaylist value) { Value = value; }
            public static implicit operator InPlaylistMusicPlaylist (MusicPlaylist value) { return new InPlaylistMusicPlaylist (value); }
        }

        public interface IIsrcCode : IValue {}
        public interface IIsrcCode<T> : IIsrcCode { new T Value { get; } }
        public class OneOrManyIsrcCode : OneOrMany<IIsrcCode>
        {
            public OneOrManyIsrcCode(IIsrcCode item) : base(item) { }
            public OneOrManyIsrcCode(IEnumerable<IIsrcCode> items) : base(items) { }
            public static implicit operator OneOrManyIsrcCode (string value) { return new OneOrManyIsrcCode (new IsrcCodestring (value)); }
            public static implicit operator OneOrManyIsrcCode (string[] values) { return new OneOrManyIsrcCode (values.Select(v => (IIsrcCode) new IsrcCodestring (v))); }
            public static implicit operator OneOrManyIsrcCode (List<string> values) { return new OneOrManyIsrcCode (values.Select(v => (IIsrcCode) new IsrcCodestring (v))); }
        }
        public struct IsrcCodestring : IIsrcCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IsrcCodestring (string value) { Value = value; }
            public static implicit operator IsrcCodestring (string value) { return new IsrcCodestring (value); }
        }

        public interface IRecordingOf : IValue {}
        public interface IRecordingOf<T> : IRecordingOf { new T Value { get; } }
        public class OneOrManyRecordingOf : OneOrMany<IRecordingOf>
        {
            public OneOrManyRecordingOf(IRecordingOf item) : base(item) { }
            public OneOrManyRecordingOf(IEnumerable<IRecordingOf> items) : base(items) { }
            public static implicit operator OneOrManyRecordingOf (MusicComposition value) { return new OneOrManyRecordingOf (new RecordingOfMusicComposition (value)); }
            public static implicit operator OneOrManyRecordingOf (MusicComposition[] values) { return new OneOrManyRecordingOf (values.Select(v => (IRecordingOf) new RecordingOfMusicComposition (v))); }
            public static implicit operator OneOrManyRecordingOf (List<MusicComposition> values) { return new OneOrManyRecordingOf (values.Select(v => (IRecordingOf) new RecordingOfMusicComposition (v))); }
        }
        public struct RecordingOfMusicComposition : IRecordingOf<MusicComposition>
        {
            object IValue.Value => this.Value;
            public MusicComposition Value { get; }
            public RecordingOfMusicComposition (MusicComposition value) { Value = value; }
            public static implicit operator RecordingOfMusicComposition (MusicComposition value) { return new RecordingOfMusicComposition (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRecording";

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist", Order = 206)]
        public OneOrManyByArtist ByArtist { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 207)]
        public OneOrManyDuration Duration { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inAlbum", Order = 208)]
        public OneOrManyInAlbum InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        [DataMember(Name = "inPlaylist", Order = 209)]
        public OneOrManyInPlaylist InPlaylist { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        [DataMember(Name = "isrcCode", Order = 210)]
        public OneOrManyIsrcCode IsrcCode { get; set; }

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        [DataMember(Name = "recordingOf", Order = 211)]
        public OneOrManyRecordingOf RecordingOf { get; set; }
    }
}
