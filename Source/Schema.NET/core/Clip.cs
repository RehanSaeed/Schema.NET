namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    [DataContract]
    public partial class Clip : CreativeWork
    {
        public interface IActor : IValue {}
        public interface IActor<T> : IActor { new T Value { get; } }
        public class OneOrManyActor : OneOrMany<IActor>
        {
            public OneOrManyActor(IActor item) : base(item) { }
            public OneOrManyActor(IEnumerable<IActor> items) : base(items) { }
            public static implicit operator OneOrManyActor (Person value) { return new OneOrManyActor (new ActorPerson (value)); }
            public static implicit operator OneOrManyActor (Person[] values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
            public static implicit operator OneOrManyActor (List<Person> values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
        }
        public struct ActorPerson : IActor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ActorPerson (Person value) { Value = value; }
            public static implicit operator ActorPerson (Person value) { return new ActorPerson (value); }
        }

        public interface IClipNumber : IValue {}
        public interface IClipNumber<T> : IClipNumber { new T Value { get; } }
        public class OneOrManyClipNumber : OneOrMany<IClipNumber>
        {
            public OneOrManyClipNumber(IClipNumber item) : base(item) { }
            public OneOrManyClipNumber(IEnumerable<IClipNumber> items) : base(items) { }
            public static implicit operator OneOrManyClipNumber (int value) { return new OneOrManyClipNumber (new ClipNumberint (value)); }
            public static implicit operator OneOrManyClipNumber (int[] values) { return new OneOrManyClipNumber (values.Select(v => (IClipNumber) new ClipNumberint (v))); }
            public static implicit operator OneOrManyClipNumber (List<int> values) { return new OneOrManyClipNumber (values.Select(v => (IClipNumber) new ClipNumberint (v))); }
            public static implicit operator OneOrManyClipNumber (string value) { return new OneOrManyClipNumber (new ClipNumberstring (value)); }
            public static implicit operator OneOrManyClipNumber (string[] values) { return new OneOrManyClipNumber (values.Select(v => (IClipNumber) new ClipNumberstring (v))); }
            public static implicit operator OneOrManyClipNumber (List<string> values) { return new OneOrManyClipNumber (values.Select(v => (IClipNumber) new ClipNumberstring (v))); }
        }
        public struct ClipNumberint : IClipNumber<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ClipNumberint (int value) { Value = value; }
            public static implicit operator ClipNumberint (int value) { return new ClipNumberint (value); }
        }
        public struct ClipNumberstring : IClipNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ClipNumberstring (string value) { Value = value; }
            public static implicit operator ClipNumberstring (string value) { return new ClipNumberstring (value); }
        }

        public interface IDirector : IValue {}
        public interface IDirector<T> : IDirector { new T Value { get; } }
        public class OneOrManyDirector : OneOrMany<IDirector>
        {
            public OneOrManyDirector(IDirector item) : base(item) { }
            public OneOrManyDirector(IEnumerable<IDirector> items) : base(items) { }
            public static implicit operator OneOrManyDirector (Person value) { return new OneOrManyDirector (new DirectorPerson (value)); }
            public static implicit operator OneOrManyDirector (Person[] values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
            public static implicit operator OneOrManyDirector (List<Person> values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
        }
        public struct DirectorPerson : IDirector<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public DirectorPerson (Person value) { Value = value; }
            public static implicit operator DirectorPerson (Person value) { return new DirectorPerson (value); }
        }

        public interface IMusicBy : IValue {}
        public interface IMusicBy<T> : IMusicBy { new T Value { get; } }
        public class OneOrManyMusicBy : OneOrMany<IMusicBy>
        {
            public OneOrManyMusicBy(IMusicBy item) : base(item) { }
            public OneOrManyMusicBy(IEnumerable<IMusicBy> items) : base(items) { }
            public static implicit operator OneOrManyMusicBy (MusicGroup value) { return new OneOrManyMusicBy (new MusicByMusicGroup (value)); }
            public static implicit operator OneOrManyMusicBy (MusicGroup[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (List<MusicGroup> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (Person value) { return new OneOrManyMusicBy (new MusicByPerson (value)); }
            public static implicit operator OneOrManyMusicBy (Person[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
            public static implicit operator OneOrManyMusicBy (List<Person> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
        }
        public struct MusicByMusicGroup : IMusicBy<MusicGroup>
        {
            object IValue.Value => this.Value;
            public MusicGroup Value { get; }
            public MusicByMusicGroup (MusicGroup value) { Value = value; }
            public static implicit operator MusicByMusicGroup (MusicGroup value) { return new MusicByMusicGroup (value); }
        }
        public struct MusicByPerson : IMusicBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public MusicByPerson (Person value) { Value = value; }
            public static implicit operator MusicByPerson (Person value) { return new MusicByPerson (value); }
        }

        public interface IPartOfEpisode : IValue {}
        public interface IPartOfEpisode<T> : IPartOfEpisode { new T Value { get; } }
        public class OneOrManyPartOfEpisode : OneOrMany<IPartOfEpisode>
        {
            public OneOrManyPartOfEpisode(IPartOfEpisode item) : base(item) { }
            public OneOrManyPartOfEpisode(IEnumerable<IPartOfEpisode> items) : base(items) { }
            public static implicit operator OneOrManyPartOfEpisode (Episode value) { return new OneOrManyPartOfEpisode (new PartOfEpisodeEpisode (value)); }
            public static implicit operator OneOrManyPartOfEpisode (Episode[] values) { return new OneOrManyPartOfEpisode (values.Select(v => (IPartOfEpisode) new PartOfEpisodeEpisode (v))); }
            public static implicit operator OneOrManyPartOfEpisode (List<Episode> values) { return new OneOrManyPartOfEpisode (values.Select(v => (IPartOfEpisode) new PartOfEpisodeEpisode (v))); }
        }
        public struct PartOfEpisodeEpisode : IPartOfEpisode<Episode>
        {
            object IValue.Value => this.Value;
            public Episode Value { get; }
            public PartOfEpisodeEpisode (Episode value) { Value = value; }
            public static implicit operator PartOfEpisodeEpisode (Episode value) { return new PartOfEpisodeEpisode (value); }
        }

        public interface IPartOfSeason : IValue {}
        public interface IPartOfSeason<T> : IPartOfSeason { new T Value { get; } }
        public class OneOrManyPartOfSeason : OneOrMany<IPartOfSeason>
        {
            public OneOrManyPartOfSeason(IPartOfSeason item) : base(item) { }
            public OneOrManyPartOfSeason(IEnumerable<IPartOfSeason> items) : base(items) { }
            public static implicit operator OneOrManyPartOfSeason (CreativeWorkSeason value) { return new OneOrManyPartOfSeason (new PartOfSeasonCreativeWorkSeason (value)); }
            public static implicit operator OneOrManyPartOfSeason (CreativeWorkSeason[] values) { return new OneOrManyPartOfSeason (values.Select(v => (IPartOfSeason) new PartOfSeasonCreativeWorkSeason (v))); }
            public static implicit operator OneOrManyPartOfSeason (List<CreativeWorkSeason> values) { return new OneOrManyPartOfSeason (values.Select(v => (IPartOfSeason) new PartOfSeasonCreativeWorkSeason (v))); }
        }
        public struct PartOfSeasonCreativeWorkSeason : IPartOfSeason<CreativeWorkSeason>
        {
            object IValue.Value => this.Value;
            public CreativeWorkSeason Value { get; }
            public PartOfSeasonCreativeWorkSeason (CreativeWorkSeason value) { Value = value; }
            public static implicit operator PartOfSeasonCreativeWorkSeason (CreativeWorkSeason value) { return new PartOfSeasonCreativeWorkSeason (value); }
        }

        public interface IPartOfSeries : IValue {}
        public interface IPartOfSeries<T> : IPartOfSeries { new T Value { get; } }
        public class OneOrManyPartOfSeries : OneOrMany<IPartOfSeries>
        {
            public OneOrManyPartOfSeries(IPartOfSeries item) : base(item) { }
            public OneOrManyPartOfSeries(IEnumerable<IPartOfSeries> items) : base(items) { }
            public static implicit operator OneOrManyPartOfSeries (CreativeWorkSeries value) { return new OneOrManyPartOfSeries (new PartOfSeriesCreativeWorkSeries (value)); }
            public static implicit operator OneOrManyPartOfSeries (CreativeWorkSeries[] values) { return new OneOrManyPartOfSeries (values.Select(v => (IPartOfSeries) new PartOfSeriesCreativeWorkSeries (v))); }
            public static implicit operator OneOrManyPartOfSeries (List<CreativeWorkSeries> values) { return new OneOrManyPartOfSeries (values.Select(v => (IPartOfSeries) new PartOfSeriesCreativeWorkSeries (v))); }
        }
        public struct PartOfSeriesCreativeWorkSeries : IPartOfSeries<CreativeWorkSeries>
        {
            object IValue.Value => this.Value;
            public CreativeWorkSeries Value { get; }
            public PartOfSeriesCreativeWorkSeries (CreativeWorkSeries value) { Value = value; }
            public static implicit operator PartOfSeriesCreativeWorkSeries (CreativeWorkSeries value) { return new PartOfSeriesCreativeWorkSeries (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Clip";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [DataMember(Name = "clipNumber", Order = 207)]
        public OneOrManyClipNumber ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 209)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 210)]
        public OneOrManyPartOfEpisode PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 211)]
        public OneOrManyPartOfSeason PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 212)]
        public OneOrManyPartOfSeries PartOfSeries { get; set; }
    }
}
