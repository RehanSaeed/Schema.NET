namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A movie.
    /// </summary>
    [DataContract]
    public partial class Movie : CreativeWork
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

        public interface ISubtitleLanguage : IValue {}
        public interface ISubtitleLanguage<T> : ISubtitleLanguage { new T Value { get; } }
        public class OneOrManySubtitleLanguage : OneOrMany<ISubtitleLanguage>
        {
            public OneOrManySubtitleLanguage(ISubtitleLanguage item) : base(item) { }
            public OneOrManySubtitleLanguage(IEnumerable<ISubtitleLanguage> items) : base(items) { }
            public static implicit operator OneOrManySubtitleLanguage (Language value) { return new OneOrManySubtitleLanguage (new SubtitleLanguageLanguage (value)); }
            public static implicit operator OneOrManySubtitleLanguage (Language[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<Language> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (string value) { return new OneOrManySubtitleLanguage (new SubtitleLanguagestring (value)); }
            public static implicit operator OneOrManySubtitleLanguage (string[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<string> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
        }
        public struct SubtitleLanguageLanguage : ISubtitleLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public SubtitleLanguageLanguage (Language value) { Value = value; }
            public static implicit operator SubtitleLanguageLanguage (Language value) { return new SubtitleLanguageLanguage (value); }
        }
        public struct SubtitleLanguagestring : ISubtitleLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SubtitleLanguagestring (string value) { Value = value; }
            public static implicit operator SubtitleLanguagestring (string value) { return new SubtitleLanguagestring (value); }
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
        public override string Type => "Movie";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 207)]
        public OneOrManyCountryOfOrigin CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 209)]
        public OneOrManyDuration Duration { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 210)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 211)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 212)]
        public OneOrManySubtitleLanguage SubtitleLanguage { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 213)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
