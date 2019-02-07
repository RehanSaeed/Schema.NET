namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class Episode : CreativeWork
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

        public interface IEpisodeNumber : IValue {}
        public interface IEpisodeNumber<T> : IEpisodeNumber { new T Value { get; } }
        public class OneOrManyEpisodeNumber : OneOrMany<IEpisodeNumber>
        {
            public OneOrManyEpisodeNumber(IEpisodeNumber item) : base(item) { }
            public OneOrManyEpisodeNumber(IEnumerable<IEpisodeNumber> items) : base(items) { }
            public static implicit operator OneOrManyEpisodeNumber (int value) { return new OneOrManyEpisodeNumber (new EpisodeNumberint (value)); }
            public static implicit operator OneOrManyEpisodeNumber (int[] values) { return new OneOrManyEpisodeNumber (values.Select(v => (IEpisodeNumber) new EpisodeNumberint (v))); }
            public static implicit operator OneOrManyEpisodeNumber (List<int> values) { return new OneOrManyEpisodeNumber (values.Select(v => (IEpisodeNumber) new EpisodeNumberint (v))); }
            public static implicit operator OneOrManyEpisodeNumber (string value) { return new OneOrManyEpisodeNumber (new EpisodeNumberstring (value)); }
            public static implicit operator OneOrManyEpisodeNumber (string[] values) { return new OneOrManyEpisodeNumber (values.Select(v => (IEpisodeNumber) new EpisodeNumberstring (v))); }
            public static implicit operator OneOrManyEpisodeNumber (List<string> values) { return new OneOrManyEpisodeNumber (values.Select(v => (IEpisodeNumber) new EpisodeNumberstring (v))); }
        }
        public struct EpisodeNumberint : IEpisodeNumber<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public EpisodeNumberint (int value) { Value = value; }
            public static implicit operator EpisodeNumberint (int value) { return new EpisodeNumberint (value); }
        }
        public struct EpisodeNumberstring : IEpisodeNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EpisodeNumberstring (string value) { Value = value; }
            public static implicit operator EpisodeNumberstring (string value) { return new EpisodeNumberstring (value); }
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

        public interface IProductionCompany : IValue {}
        public interface IProductionCompany<T> : IProductionCompany { new T Value { get; } }
        public class OneOrManyProductionCompany : OneOrMany<IProductionCompany>
        {
            public OneOrManyProductionCompany(IProductionCompany item) : base(item) { }
            public OneOrManyProductionCompany(IEnumerable<IProductionCompany> items) : base(items) { }
            public static implicit operator OneOrManyProductionCompany (Organization value) { return new OneOrManyProductionCompany (new ProductionCompanyOrganization (value)); }
            public static implicit operator OneOrManyProductionCompany (Organization[] values) { return new OneOrManyProductionCompany (values.Select(v => (IProductionCompany) new ProductionCompanyOrganization (v))); }
            public static implicit operator OneOrManyProductionCompany (List<Organization> values) { return new OneOrManyProductionCompany (values.Select(v => (IProductionCompany) new ProductionCompanyOrganization (v))); }
        }
        public struct ProductionCompanyOrganization : IProductionCompany<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProductionCompanyOrganization (Organization value) { Value = value; }
            public static implicit operator ProductionCompanyOrganization (Organization value) { return new ProductionCompanyOrganization (value); }
        }

        public interface ITrailer : IValue {}
        public interface ITrailer<T> : ITrailer { new T Value { get; } }
        public class OneOrManyTrailer : OneOrMany<ITrailer>
        {
            public OneOrManyTrailer(ITrailer item) : base(item) { }
            public OneOrManyTrailer(IEnumerable<ITrailer> items) : base(items) { }
            public static implicit operator OneOrManyTrailer (VideoObject value) { return new OneOrManyTrailer (new TrailerVideoObject (value)); }
            public static implicit operator OneOrManyTrailer (VideoObject[] values) { return new OneOrManyTrailer (values.Select(v => (ITrailer) new TrailerVideoObject (v))); }
            public static implicit operator OneOrManyTrailer (List<VideoObject> values) { return new OneOrManyTrailer (values.Select(v => (ITrailer) new TrailerVideoObject (v))); }
        }
        public struct TrailerVideoObject : ITrailer<VideoObject>
        {
            object IValue.Value => this.Value;
            public VideoObject Value { get; }
            public TrailerVideoObject (VideoObject value) { Value = value; }
            public static implicit operator TrailerVideoObject (VideoObject value) { return new TrailerVideoObject (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Episode";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 207)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// Position of the episode within an ordered group of episodes.
        /// </summary>
        [DataMember(Name = "episodeNumber", Order = 208)]
        public OneOrManyEpisodeNumber EpisodeNumber { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 209)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 210)]
        public OneOrManyPartOfSeason PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 211)]
        public OneOrManyPartOfSeries PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 212)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 213)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
