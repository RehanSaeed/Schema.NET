namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A video game series.
    /// </summary>
    [DataContract]
    public class VideoGameSeries : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VideoGameSeries";

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem")]
        public Thing GameItem { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform")]
        public object GamePlatform { get; protected set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Thing GamePlatformThing
        {
            get => this.GamePlatform as Thing;
            set => this.GamePlatform = value;
        }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string GamePlatformText
        {
            get => this.GamePlatform as string;
            set => this.GamePlatform = value;
        }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Uri GamePlatformURL
        {
            get => this.GamePlatform as Uri;
            set => this.GamePlatform = value;
        }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes")]
        public int NumberOfEpisodes { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer")]
        public VideoObject Trailer { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode")]
        public CreativeWork CheatCode { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute")]
        public Thing CharacterAttribute { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation")]
        public object GameLocation { get; protected set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [IgnoreDataMember]
        public Uri GameLocationURL
        {
            get => this.GameLocation as Uri;
            set => this.GameLocation = value;
        }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [IgnoreDataMember]
        public Place GameLocationPlace
        {
            get => this.GameLocation as Place;
            set => this.GameLocation = value;
        }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress GameLocationPostalAddress
        {
            get => this.GameLocation as PostalAddress;
            set => this.GameLocation = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy")]
        public object MusicBy { get; protected set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public Person MusicByPerson
        {
            get => this.MusicBy as Person;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public MusicGroup MusicByMusicGroup
        {
            get => this.MusicBy as MusicGroup;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason")]
        public CreativeWorkSeason ContainsSeason { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest")]
        public Thing Quest { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode")]
        public GamePlayMode PlayMode { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons")]
        public int NumberOfSeasons { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers")]
        public QuantitativeValue NumberOfPlayers { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode")]
        public Episode Episode { get; set; }
    }
}
