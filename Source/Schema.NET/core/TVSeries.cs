namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class TVSeries : CreativeWorkSeries
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

        public interface IContainsSeason : IValue {}
        public interface IContainsSeason<T> : IContainsSeason { new T Value { get; } }
        public class OneOrManyContainsSeason : OneOrMany<IContainsSeason>
        {
            public OneOrManyContainsSeason(IContainsSeason item) : base(item) { }
            public OneOrManyContainsSeason(IEnumerable<IContainsSeason> items) : base(items) { }
            public static implicit operator OneOrManyContainsSeason (CreativeWorkSeason value) { return new OneOrManyContainsSeason (new ContainsSeasonCreativeWorkSeason (value)); }
            public static implicit operator OneOrManyContainsSeason (CreativeWorkSeason[] values) { return new OneOrManyContainsSeason (values.Select(v => (IContainsSeason) new ContainsSeasonCreativeWorkSeason (v))); }
            public static implicit operator OneOrManyContainsSeason (List<CreativeWorkSeason> values) { return new OneOrManyContainsSeason (values.Select(v => (IContainsSeason) new ContainsSeasonCreativeWorkSeason (v))); }
        }
        public struct ContainsSeasonCreativeWorkSeason : IContainsSeason<CreativeWorkSeason>
        {
            object IValue.Value => this.Value;
            public CreativeWorkSeason Value { get; }
            public ContainsSeasonCreativeWorkSeason (CreativeWorkSeason value) { Value = value; }
            public static implicit operator ContainsSeasonCreativeWorkSeason (CreativeWorkSeason value) { return new ContainsSeasonCreativeWorkSeason (value); }
        }

        public interface ICountryOfOrigin : IValue {}
        public interface ICountryOfOrigin<T> : ICountryOfOrigin { new T Value { get; } }
        public class OneOrManyCountryOfOrigin : OneOrMany<ICountryOfOrigin>
        {
            public OneOrManyCountryOfOrigin(ICountryOfOrigin item) : base(item) { }
            public OneOrManyCountryOfOrigin(IEnumerable<ICountryOfOrigin> items) : base(items) { }
            public static implicit operator OneOrManyCountryOfOrigin (Country value) { return new OneOrManyCountryOfOrigin (new CountryOfOriginCountry (value)); }
            public static implicit operator OneOrManyCountryOfOrigin (Country[] values) { return new OneOrManyCountryOfOrigin (values.Select(v => (ICountryOfOrigin) new CountryOfOriginCountry (v))); }
            public static implicit operator OneOrManyCountryOfOrigin (List<Country> values) { return new OneOrManyCountryOfOrigin (values.Select(v => (ICountryOfOrigin) new CountryOfOriginCountry (v))); }
        }
        public struct CountryOfOriginCountry : ICountryOfOrigin<Country>
        {
            object IValue.Value => this.Value;
            public Country Value { get; }
            public CountryOfOriginCountry (Country value) { Value = value; }
            public static implicit operator CountryOfOriginCountry (Country value) { return new CountryOfOriginCountry (value); }
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

        public interface IEpisode : IValue {}
        public interface IEpisode<T> : IEpisode { new T Value { get; } }
        public class OneOrManyEpisode : OneOrMany<IEpisode>
        {
            public OneOrManyEpisode(IEpisode item) : base(item) { }
            public OneOrManyEpisode(IEnumerable<IEpisode> items) : base(items) { }
            public static implicit operator OneOrManyEpisode (Episode value) { return new OneOrManyEpisode (new EpisodeEpisode (value)); }
            public static implicit operator OneOrManyEpisode (Episode[] values) { return new OneOrManyEpisode (values.Select(v => (IEpisode) new EpisodeEpisode (v))); }
            public static implicit operator OneOrManyEpisode (List<Episode> values) { return new OneOrManyEpisode (values.Select(v => (IEpisode) new EpisodeEpisode (v))); }
        }
        public struct EpisodeEpisode : IEpisode<Episode>
        {
            object IValue.Value => this.Value;
            public Episode Value { get; }
            public EpisodeEpisode (Episode value) { Value = value; }
            public static implicit operator EpisodeEpisode (Episode value) { return new EpisodeEpisode (value); }
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

        public interface INumberOfEpisodes : IValue {}
        public interface INumberOfEpisodes<T> : INumberOfEpisodes { new T Value { get; } }
        public class OneOrManyNumberOfEpisodes : OneOrMany<INumberOfEpisodes>
        {
            public OneOrManyNumberOfEpisodes(INumberOfEpisodes item) : base(item) { }
            public OneOrManyNumberOfEpisodes(IEnumerable<INumberOfEpisodes> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfEpisodes (int value) { return new OneOrManyNumberOfEpisodes (new NumberOfEpisodesint (value)); }
            public static implicit operator OneOrManyNumberOfEpisodes (int[] values) { return new OneOrManyNumberOfEpisodes (values.Select(v => (INumberOfEpisodes) new NumberOfEpisodesint (v))); }
            public static implicit operator OneOrManyNumberOfEpisodes (List<int> values) { return new OneOrManyNumberOfEpisodes (values.Select(v => (INumberOfEpisodes) new NumberOfEpisodesint (v))); }
        }
        public struct NumberOfEpisodesint : INumberOfEpisodes<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfEpisodesint (int value) { Value = value; }
            public static implicit operator NumberOfEpisodesint (int value) { return new NumberOfEpisodesint (value); }
        }

        public interface INumberOfSeasons : IValue {}
        public interface INumberOfSeasons<T> : INumberOfSeasons { new T Value { get; } }
        public class OneOrManyNumberOfSeasons : OneOrMany<INumberOfSeasons>
        {
            public OneOrManyNumberOfSeasons(INumberOfSeasons item) : base(item) { }
            public OneOrManyNumberOfSeasons(IEnumerable<INumberOfSeasons> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfSeasons (int value) { return new OneOrManyNumberOfSeasons (new NumberOfSeasonsint (value)); }
            public static implicit operator OneOrManyNumberOfSeasons (int[] values) { return new OneOrManyNumberOfSeasons (values.Select(v => (INumberOfSeasons) new NumberOfSeasonsint (v))); }
            public static implicit operator OneOrManyNumberOfSeasons (List<int> values) { return new OneOrManyNumberOfSeasons (values.Select(v => (INumberOfSeasons) new NumberOfSeasonsint (v))); }
        }
        public struct NumberOfSeasonsint : INumberOfSeasons<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfSeasonsint (int value) { Value = value; }
            public static implicit operator NumberOfSeasonsint (int value) { return new NumberOfSeasonsint (value); }
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
        public override string Type => "TVSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 407)]
        public OneOrManyContainsSeason ContainsSeason { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 408)]
        public OneOrManyCountryOfOrigin CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 409)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 410)]
        public OneOrManyEpisode Episode { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 411)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 412)]
        public OneOrManyNumberOfEpisodes NumberOfEpisodes { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 413)]
        public OneOrManyNumberOfSeasons NumberOfSeasons { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 414)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 415)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
