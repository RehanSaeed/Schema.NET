namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A video game series.
    /// </summary>
    [DataContract]
    public partial class VideoGameSeries : CreativeWorkSeries
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

        public interface ICharacterAttribute : IValue {}
        public interface ICharacterAttribute<T> : ICharacterAttribute { new T Value { get; } }
        public class OneOrManyCharacterAttribute : OneOrMany<ICharacterAttribute>
        {
            public OneOrManyCharacterAttribute(ICharacterAttribute item) : base(item) { }
            public OneOrManyCharacterAttribute(IEnumerable<ICharacterAttribute> items) : base(items) { }
            public static implicit operator OneOrManyCharacterAttribute (Thing value) { return new OneOrManyCharacterAttribute (new CharacterAttributeThing (value)); }
            public static implicit operator OneOrManyCharacterAttribute (Thing[] values) { return new OneOrManyCharacterAttribute (values.Select(v => (ICharacterAttribute) new CharacterAttributeThing (v))); }
            public static implicit operator OneOrManyCharacterAttribute (List<Thing> values) { return new OneOrManyCharacterAttribute (values.Select(v => (ICharacterAttribute) new CharacterAttributeThing (v))); }
        }
        public struct CharacterAttributeThing : ICharacterAttribute<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public CharacterAttributeThing (Thing value) { Value = value; }
            public static implicit operator CharacterAttributeThing (Thing value) { return new CharacterAttributeThing (value); }
        }

        public interface ICheatCode : IValue {}
        public interface ICheatCode<T> : ICheatCode { new T Value { get; } }
        public class OneOrManyCheatCode : OneOrMany<ICheatCode>
        {
            public OneOrManyCheatCode(ICheatCode item) : base(item) { }
            public OneOrManyCheatCode(IEnumerable<ICheatCode> items) : base(items) { }
            public static implicit operator OneOrManyCheatCode (CreativeWork value) { return new OneOrManyCheatCode (new CheatCodeCreativeWork (value)); }
            public static implicit operator OneOrManyCheatCode (CreativeWork[] values) { return new OneOrManyCheatCode (values.Select(v => (ICheatCode) new CheatCodeCreativeWork (v))); }
            public static implicit operator OneOrManyCheatCode (List<CreativeWork> values) { return new OneOrManyCheatCode (values.Select(v => (ICheatCode) new CheatCodeCreativeWork (v))); }
        }
        public struct CheatCodeCreativeWork : ICheatCode<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public CheatCodeCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator CheatCodeCreativeWork (CreativeWork value) { return new CheatCodeCreativeWork (value); }
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

        public interface IGameItem : IValue {}
        public interface IGameItem<T> : IGameItem { new T Value { get; } }
        public class OneOrManyGameItem : OneOrMany<IGameItem>
        {
            public OneOrManyGameItem(IGameItem item) : base(item) { }
            public OneOrManyGameItem(IEnumerable<IGameItem> items) : base(items) { }
            public static implicit operator OneOrManyGameItem (Thing value) { return new OneOrManyGameItem (new GameItemThing (value)); }
            public static implicit operator OneOrManyGameItem (Thing[] values) { return new OneOrManyGameItem (values.Select(v => (IGameItem) new GameItemThing (v))); }
            public static implicit operator OneOrManyGameItem (List<Thing> values) { return new OneOrManyGameItem (values.Select(v => (IGameItem) new GameItemThing (v))); }
        }
        public struct GameItemThing : IGameItem<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public GameItemThing (Thing value) { Value = value; }
            public static implicit operator GameItemThing (Thing value) { return new GameItemThing (value); }
        }

        public interface IGameLocation : IValue {}
        public interface IGameLocation<T> : IGameLocation { new T Value { get; } }
        public class OneOrManyGameLocation : OneOrMany<IGameLocation>
        {
            public OneOrManyGameLocation(IGameLocation item) : base(item) { }
            public OneOrManyGameLocation(IEnumerable<IGameLocation> items) : base(items) { }
            public static implicit operator OneOrManyGameLocation (Place value) { return new OneOrManyGameLocation (new GameLocationPlace (value)); }
            public static implicit operator OneOrManyGameLocation (Place[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPlace (v))); }
            public static implicit operator OneOrManyGameLocation (List<Place> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPlace (v))); }
            public static implicit operator OneOrManyGameLocation (PostalAddress value) { return new OneOrManyGameLocation (new GameLocationPostalAddress (value)); }
            public static implicit operator OneOrManyGameLocation (PostalAddress[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPostalAddress (v))); }
            public static implicit operator OneOrManyGameLocation (List<PostalAddress> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPostalAddress (v))); }
            public static implicit operator OneOrManyGameLocation (Uri value) { return new OneOrManyGameLocation (new GameLocationUri (value)); }
            public static implicit operator OneOrManyGameLocation (Uri[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationUri (v))); }
            public static implicit operator OneOrManyGameLocation (List<Uri> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationUri (v))); }
        }
        public struct GameLocationPlace : IGameLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GameLocationPlace (Place value) { Value = value; }
            public static implicit operator GameLocationPlace (Place value) { return new GameLocationPlace (value); }
        }
        public struct GameLocationPostalAddress : IGameLocation<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public GameLocationPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator GameLocationPostalAddress (PostalAddress value) { return new GameLocationPostalAddress (value); }
        }
        public struct GameLocationUri : IGameLocation<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GameLocationUri (Uri value) { Value = value; }
            public static implicit operator GameLocationUri (Uri value) { return new GameLocationUri (value); }
        }

        public interface IGamePlatform : IValue {}
        public interface IGamePlatform<T> : IGamePlatform { new T Value { get; } }
        public class OneOrManyGamePlatform : OneOrMany<IGamePlatform>
        {
            public OneOrManyGamePlatform(IGamePlatform item) : base(item) { }
            public OneOrManyGamePlatform(IEnumerable<IGamePlatform> items) : base(items) { }
            public static implicit operator OneOrManyGamePlatform (string value) { return new OneOrManyGamePlatform (new GamePlatformstring (value)); }
            public static implicit operator OneOrManyGamePlatform (string[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformstring (v))); }
            public static implicit operator OneOrManyGamePlatform (List<string> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformstring (v))); }
            public static implicit operator OneOrManyGamePlatform (Thing value) { return new OneOrManyGamePlatform (new GamePlatformThing (value)); }
            public static implicit operator OneOrManyGamePlatform (Thing[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformThing (v))); }
            public static implicit operator OneOrManyGamePlatform (List<Thing> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformThing (v))); }
            public static implicit operator OneOrManyGamePlatform (Uri value) { return new OneOrManyGamePlatform (new GamePlatformUri (value)); }
            public static implicit operator OneOrManyGamePlatform (Uri[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformUri (v))); }
            public static implicit operator OneOrManyGamePlatform (List<Uri> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformUri (v))); }
        }
        public struct GamePlatformstring : IGamePlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public GamePlatformstring (string value) { Value = value; }
            public static implicit operator GamePlatformstring (string value) { return new GamePlatformstring (value); }
        }
        public struct GamePlatformThing : IGamePlatform<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public GamePlatformThing (Thing value) { Value = value; }
            public static implicit operator GamePlatformThing (Thing value) { return new GamePlatformThing (value); }
        }
        public struct GamePlatformUri : IGamePlatform<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GamePlatformUri (Uri value) { Value = value; }
            public static implicit operator GamePlatformUri (Uri value) { return new GamePlatformUri (value); }
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

        public interface INumberOfPlayers : IValue {}
        public interface INumberOfPlayers<T> : INumberOfPlayers { new T Value { get; } }
        public class OneOrManyNumberOfPlayers : OneOrMany<INumberOfPlayers>
        {
            public OneOrManyNumberOfPlayers(INumberOfPlayers item) : base(item) { }
            public OneOrManyNumberOfPlayers(IEnumerable<INumberOfPlayers> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfPlayers (QuantitativeValue value) { return new OneOrManyNumberOfPlayers (new NumberOfPlayersQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfPlayers (QuantitativeValue[] values) { return new OneOrManyNumberOfPlayers (values.Select(v => (INumberOfPlayers) new NumberOfPlayersQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfPlayers (List<QuantitativeValue> values) { return new OneOrManyNumberOfPlayers (values.Select(v => (INumberOfPlayers) new NumberOfPlayersQuantitativeValue (v))); }
        }
        public struct NumberOfPlayersQuantitativeValue : INumberOfPlayers<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfPlayersQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfPlayersQuantitativeValue (QuantitativeValue value) { return new NumberOfPlayersQuantitativeValue (value); }
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

        public interface IPlayMode : IValue {}
        public interface IPlayMode<T> : IPlayMode { new T Value { get; } }
        public class OneOrManyPlayMode : OneOrMany<IPlayMode>
        {
            public OneOrManyPlayMode(IPlayMode item) : base(item) { }
            public OneOrManyPlayMode(IEnumerable<IPlayMode> items) : base(items) { }
            public static implicit operator OneOrManyPlayMode (GamePlayMode value) { return new OneOrManyPlayMode (new PlayModeGamePlayMode (value)); }
            public static implicit operator OneOrManyPlayMode (GamePlayMode[] values) { return new OneOrManyPlayMode (values.Select(v => (IPlayMode) new PlayModeGamePlayMode (v))); }
            public static implicit operator OneOrManyPlayMode (List<GamePlayMode> values) { return new OneOrManyPlayMode (values.Select(v => (IPlayMode) new PlayModeGamePlayMode (v))); }
        }
        public struct PlayModeGamePlayMode : IPlayMode<GamePlayMode>
        {
            object IValue.Value => this.Value;
            public GamePlayMode Value { get; }
            public PlayModeGamePlayMode (GamePlayMode value) { Value = value; }
            public static implicit operator PlayModeGamePlayMode (GamePlayMode value) { return new PlayModeGamePlayMode (value); }
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

        public interface IQuest : IValue {}
        public interface IQuest<T> : IQuest { new T Value { get; } }
        public class OneOrManyQuest : OneOrMany<IQuest>
        {
            public OneOrManyQuest(IQuest item) : base(item) { }
            public OneOrManyQuest(IEnumerable<IQuest> items) : base(items) { }
            public static implicit operator OneOrManyQuest (Thing value) { return new OneOrManyQuest (new QuestThing (value)); }
            public static implicit operator OneOrManyQuest (Thing[] values) { return new OneOrManyQuest (values.Select(v => (IQuest) new QuestThing (v))); }
            public static implicit operator OneOrManyQuest (List<Thing> values) { return new OneOrManyQuest (values.Select(v => (IQuest) new QuestThing (v))); }
        }
        public struct QuestThing : IQuest<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public QuestThing (Thing value) { Value = value; }
            public static implicit operator QuestThing (Thing value) { return new QuestThing (value); }
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
        public override string Type => "VideoGameSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 407)]
        public OneOrManyCharacterAttribute CharacterAttribute { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 408)]
        public OneOrManyCheatCode CheatCode { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 409)]
        public OneOrManyContainsSeason ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 410)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 411)]
        public OneOrManyEpisode Episode { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 412)]
        public OneOrManyGameItem GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 413)]
        public OneOrManyGameLocation GameLocation { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 414)]
        public OneOrManyGamePlatform GamePlatform { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 415)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 416)]
        public OneOrManyNumberOfEpisodes NumberOfEpisodes { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 417)]
        public OneOrManyNumberOfPlayers NumberOfPlayers { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 418)]
        public OneOrManyNumberOfSeasons NumberOfSeasons { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 419)]
        public OneOrManyPlayMode PlayMode { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 420)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 421)]
        public OneOrManyQuest Quest { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 422)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
