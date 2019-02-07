namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    [DataContract]
    public partial class MusicGroup : PerformingGroup
    {
        public interface IAlbum : IValue {}
        public interface IAlbum<T> : IAlbum { new T Value { get; } }
        public class OneOrManyAlbum : OneOrMany<IAlbum>
        {
            public OneOrManyAlbum(IAlbum item) : base(item) { }
            public OneOrManyAlbum(IEnumerable<IAlbum> items) : base(items) { }
            public static implicit operator OneOrManyAlbum (MusicAlbum value) { return new OneOrManyAlbum (new AlbumMusicAlbum (value)); }
            public static implicit operator OneOrManyAlbum (MusicAlbum[] values) { return new OneOrManyAlbum (values.Select(v => (IAlbum) new AlbumMusicAlbum (v))); }
            public static implicit operator OneOrManyAlbum (List<MusicAlbum> values) { return new OneOrManyAlbum (values.Select(v => (IAlbum) new AlbumMusicAlbum (v))); }
        }
        public struct AlbumMusicAlbum : IAlbum<MusicAlbum>
        {
            object IValue.Value => this.Value;
            public MusicAlbum Value { get; }
            public AlbumMusicAlbum (MusicAlbum value) { Value = value; }
            public static implicit operator AlbumMusicAlbum (MusicAlbum value) { return new AlbumMusicAlbum (value); }
        }

        public interface IGenre : IValue {}
        public interface IGenre<T> : IGenre { new T Value { get; } }
        public class OneOrManyGenre : OneOrMany<IGenre>
        {
            public OneOrManyGenre(IGenre item) : base(item) { }
            public OneOrManyGenre(IEnumerable<IGenre> items) : base(items) { }
            public static implicit operator OneOrManyGenre (string value) { return new OneOrManyGenre (new Genrestring (value)); }
            public static implicit operator OneOrManyGenre (string[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (List<string> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (Uri value) { return new OneOrManyGenre (new GenreUri (value)); }
            public static implicit operator OneOrManyGenre (Uri[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
            public static implicit operator OneOrManyGenre (List<Uri> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
        }
        public struct Genrestring : IGenre<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Genrestring (string value) { Value = value; }
            public static implicit operator Genrestring (string value) { return new Genrestring (value); }
        }
        public struct GenreUri : IGenre<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GenreUri (Uri value) { Value = value; }
            public static implicit operator GenreUri (Uri value) { return new GenreUri (value); }
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
        public override string Type => "MusicGroup";

        /// <summary>
        /// A music album.
        /// </summary>
        [DataMember(Name = "album", Order = 306)]
        public OneOrManyAlbum Album { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 307)]
        public OneOrManyGenre Genre { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [DataMember(Name = "track", Order = 308)]
        public OneOrManyTrack Track { get; set; }
    }
}
