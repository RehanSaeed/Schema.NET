namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// </summary>
    [DataContract]
    public partial class CreativeWorkSeason : CreativeWork
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

        public interface ISeasonNumber : IValue {}
        public interface ISeasonNumber<T> : ISeasonNumber { new T Value { get; } }
        public class OneOrManySeasonNumber : OneOrMany<ISeasonNumber>
        {
            public OneOrManySeasonNumber(ISeasonNumber item) : base(item) { }
            public OneOrManySeasonNumber(IEnumerable<ISeasonNumber> items) : base(items) { }
            public static implicit operator OneOrManySeasonNumber (int value) { return new OneOrManySeasonNumber (new SeasonNumberint (value)); }
            public static implicit operator OneOrManySeasonNumber (int[] values) { return new OneOrManySeasonNumber (values.Select(v => (ISeasonNumber) new SeasonNumberint (v))); }
            public static implicit operator OneOrManySeasonNumber (List<int> values) { return new OneOrManySeasonNumber (values.Select(v => (ISeasonNumber) new SeasonNumberint (v))); }
            public static implicit operator OneOrManySeasonNumber (string value) { return new OneOrManySeasonNumber (new SeasonNumberstring (value)); }
            public static implicit operator OneOrManySeasonNumber (string[] values) { return new OneOrManySeasonNumber (values.Select(v => (ISeasonNumber) new SeasonNumberstring (v))); }
            public static implicit operator OneOrManySeasonNumber (List<string> values) { return new OneOrManySeasonNumber (values.Select(v => (ISeasonNumber) new SeasonNumberstring (v))); }
        }
        public struct SeasonNumberint : ISeasonNumber<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public SeasonNumberint (int value) { Value = value; }
            public static implicit operator SeasonNumberint (int value) { return new SeasonNumberint (value); }
        }
        public struct SeasonNumberstring : ISeasonNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SeasonNumberstring (string value) { Value = value; }
            public static implicit operator SeasonNumberstring (string value) { return new SeasonNumberstring (value); }
        }

        public interface IStartDate : IValue {}
        public interface IStartDate<T> : IStartDate { new T Value { get; } }
        public class OneOrManyStartDate : OneOrMany<IStartDate>
        {
            public OneOrManyStartDate(IStartDate item) : base(item) { }
            public OneOrManyStartDate(IEnumerable<IStartDate> items) : base(items) { }
            public static implicit operator OneOrManyStartDate (DateTimeOffset value) { return new OneOrManyStartDate (new StartDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartDate (DateTimeOffset[] values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartDate (List<DateTimeOffset> values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
        }
        public struct StartDateDateTimeOffset : IStartDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartDateDateTimeOffset (DateTimeOffset value) { return new StartDateDateTimeOffset (value); }
        }

        public interface IEndDate : IValue {}
        public interface IEndDate<T> : IEndDate { new T Value { get; } }
        public class OneOrManyEndDate : OneOrMany<IEndDate>
        {
            public OneOrManyEndDate(IEndDate item) : base(item) { }
            public OneOrManyEndDate(IEnumerable<IEndDate> items) : base(items) { }
            public static implicit operator OneOrManyEndDate (DateTimeOffset value) { return new OneOrManyEndDate (new EndDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndDate (DateTimeOffset[] values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndDate (List<DateTimeOffset> values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
        }
        public struct EndDateDateTimeOffset : IEndDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndDateDateTimeOffset (DateTimeOffset value) { return new EndDateDateTimeOffset (value); }
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
        public override string Type => "CreativeWorkSeason";

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
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 208)]
        public OneOrManyEpisode Episode { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 209)]
        public OneOrManyNumberOfEpisodes NumberOfEpisodes { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 210)]
        public OneOrManyPartOfSeries PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 211)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        [DataMember(Name = "seasonNumber", Order = 212)]
        public OneOrManySeasonNumber SeasonNumber { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 213)]
        public OneOrManyStartDate StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 214)]
        public OneOrManyEndDate EndDate { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 215)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
