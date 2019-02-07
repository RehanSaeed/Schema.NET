namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    [DataContract]
    public partial class MusicAlbum : MusicPlaylist
    {
        public interface IAlbumProductionType : IValue {}
        public interface IAlbumProductionType<T> : IAlbumProductionType { new T Value { get; } }
        public class OneOrManyAlbumProductionType : OneOrMany<IAlbumProductionType>
        {
            public OneOrManyAlbumProductionType(IAlbumProductionType item) : base(item) { }
            public OneOrManyAlbumProductionType(IEnumerable<IAlbumProductionType> items) : base(items) { }
            public static implicit operator OneOrManyAlbumProductionType (MusicAlbumProductionType value) { return new OneOrManyAlbumProductionType (new AlbumProductionTypeMusicAlbumProductionType (value)); }
            public static implicit operator OneOrManyAlbumProductionType (MusicAlbumProductionType[] values) { return new OneOrManyAlbumProductionType (values.Select(v => (IAlbumProductionType) new AlbumProductionTypeMusicAlbumProductionType (v))); }
            public static implicit operator OneOrManyAlbumProductionType (List<MusicAlbumProductionType> values) { return new OneOrManyAlbumProductionType (values.Select(v => (IAlbumProductionType) new AlbumProductionTypeMusicAlbumProductionType (v))); }
        }
        public struct AlbumProductionTypeMusicAlbumProductionType : IAlbumProductionType<MusicAlbumProductionType>
        {
            object IValue.Value => this.Value;
            public MusicAlbumProductionType Value { get; }
            public AlbumProductionTypeMusicAlbumProductionType (MusicAlbumProductionType value) { Value = value; }
            public static implicit operator AlbumProductionTypeMusicAlbumProductionType (MusicAlbumProductionType value) { return new AlbumProductionTypeMusicAlbumProductionType (value); }
        }

        public interface IAlbumRelease : IValue {}
        public interface IAlbumRelease<T> : IAlbumRelease { new T Value { get; } }
        public class OneOrManyAlbumRelease : OneOrMany<IAlbumRelease>
        {
            public OneOrManyAlbumRelease(IAlbumRelease item) : base(item) { }
            public OneOrManyAlbumRelease(IEnumerable<IAlbumRelease> items) : base(items) { }
            public static implicit operator OneOrManyAlbumRelease (MusicRelease value) { return new OneOrManyAlbumRelease (new AlbumReleaseMusicRelease (value)); }
            public static implicit operator OneOrManyAlbumRelease (MusicRelease[] values) { return new OneOrManyAlbumRelease (values.Select(v => (IAlbumRelease) new AlbumReleaseMusicRelease (v))); }
            public static implicit operator OneOrManyAlbumRelease (List<MusicRelease> values) { return new OneOrManyAlbumRelease (values.Select(v => (IAlbumRelease) new AlbumReleaseMusicRelease (v))); }
        }
        public struct AlbumReleaseMusicRelease : IAlbumRelease<MusicRelease>
        {
            object IValue.Value => this.Value;
            public MusicRelease Value { get; }
            public AlbumReleaseMusicRelease (MusicRelease value) { Value = value; }
            public static implicit operator AlbumReleaseMusicRelease (MusicRelease value) { return new AlbumReleaseMusicRelease (value); }
        }

        public interface IAlbumReleaseType : IValue {}
        public interface IAlbumReleaseType<T> : IAlbumReleaseType { new T Value { get; } }
        public class OneOrManyAlbumReleaseType : OneOrMany<IAlbumReleaseType>
        {
            public OneOrManyAlbumReleaseType(IAlbumReleaseType item) : base(item) { }
            public OneOrManyAlbumReleaseType(IEnumerable<IAlbumReleaseType> items) : base(items) { }
            public static implicit operator OneOrManyAlbumReleaseType (MusicAlbumReleaseType value) { return new OneOrManyAlbumReleaseType (new AlbumReleaseTypeMusicAlbumReleaseType (value)); }
            public static implicit operator OneOrManyAlbumReleaseType (MusicAlbumReleaseType[] values) { return new OneOrManyAlbumReleaseType (values.Select(v => (IAlbumReleaseType) new AlbumReleaseTypeMusicAlbumReleaseType (v))); }
            public static implicit operator OneOrManyAlbumReleaseType (List<MusicAlbumReleaseType> values) { return new OneOrManyAlbumReleaseType (values.Select(v => (IAlbumReleaseType) new AlbumReleaseTypeMusicAlbumReleaseType (v))); }
        }
        public struct AlbumReleaseTypeMusicAlbumReleaseType : IAlbumReleaseType<MusicAlbumReleaseType>
        {
            object IValue.Value => this.Value;
            public MusicAlbumReleaseType Value { get; }
            public AlbumReleaseTypeMusicAlbumReleaseType (MusicAlbumReleaseType value) { Value = value; }
            public static implicit operator AlbumReleaseTypeMusicAlbumReleaseType (MusicAlbumReleaseType value) { return new AlbumReleaseTypeMusicAlbumReleaseType (value); }
        }

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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicAlbum";

        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        [DataMember(Name = "albumProductionType", Order = 306)]
        public OneOrManyAlbumProductionType AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        [DataMember(Name = "albumRelease", Order = 307)]
        public OneOrManyAlbumRelease AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        [DataMember(Name = "albumReleaseType", Order = 308)]
        public OneOrManyAlbumReleaseType AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [DataMember(Name = "byArtist", Order = 309)]
        public OneOrManyByArtist ByArtist { get; set; }
    }
}
