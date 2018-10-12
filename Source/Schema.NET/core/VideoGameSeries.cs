namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A video game series.
    /// </summary>
    [DataContract]
    public partial class VideoGameSeries : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGameSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Person>? Actor { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? CharacterAttribute { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWork>? CheatCode { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWorkSeason>? ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Person>? Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Episode>? Episode { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 412)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 413)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, PostalAddress, Uri>? GameLocation { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 414)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Thing, Uri>? GamePlatform { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 415)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicGroup, Person>? MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 416)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfEpisodes { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 417)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<QuantitativeValue>? NumberOfPlayers { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 418)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfSeasons { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 419)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<GamePlayMode?>? PlayMode { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 420)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? ProductionCompany { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 421)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? Quest { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 422)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<VideoObject>? Trailer { get; set; }
    }
}
