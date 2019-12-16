namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A video game series.
    /// </summary>
    public partial interface IVideoGameSeries : ICreativeWorkSeries
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        OneOrMany<IThing> CharacterAttribute { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        OneOrMany<ICreativeWork> CheatCode { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        OneOrMany<ICreativeWorkSeason> ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        OneOrMany<IThing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        Values<IPlace, IPostalAddress, Uri> GameLocation { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        Values<string, IThing, Uri> GamePlatform { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfPlayers { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        OneOrMany<int?> NumberOfSeasons { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        OneOrMany<GamePlayMode?> PlayMode { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        OneOrMany<IThing> Quest { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject> Trailer { get; set; }
    }

    /// <summary>
    /// A video game series.
    /// </summary>
    [DataContract]
    public partial class VideoGameSeries : CreativeWorkSeries, IVideoGameSeries, IEquatable<VideoGameSeries>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> CharacterAttribute { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> CheatCode { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeason> ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 411)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 412)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 413)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, Uri> GameLocation { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 414)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing, Uri> GamePlatform { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 415)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 416)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 417)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfPlayers { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 418)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfSeasons { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 419)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<GamePlayMode?> PlayMode { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 420)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 421)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Quest { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 422)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }

        /// <inheritdoc/>
        public bool Equals(VideoGameSeries other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.Actor == other.Actor &&
                this.CharacterAttribute == other.CharacterAttribute &&
                this.CheatCode == other.CheatCode &&
                this.ContainsSeason == other.ContainsSeason &&
                this.Director == other.Director &&
                this.Episode == other.Episode &&
                this.GameItem == other.GameItem &&
                this.GameLocation == other.GameLocation &&
                this.GamePlatform == other.GamePlatform &&
                this.MusicBy == other.MusicBy &&
                this.NumberOfEpisodes == other.NumberOfEpisodes &&
                this.NumberOfPlayers == other.NumberOfPlayers &&
                this.NumberOfSeasons == other.NumberOfSeasons &&
                this.PlayMode == other.PlayMode &&
                this.ProductionCompany == other.ProductionCompany &&
                this.Quest == other.Quest &&
                this.Trailer == other.Trailer &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as VideoGameSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.CharacterAttribute)
            .And(this.CheatCode)
            .And(this.ContainsSeason)
            .And(this.Director)
            .And(this.Episode)
            .And(this.GameItem)
            .And(this.GameLocation)
            .And(this.GamePlatform)
            .And(this.MusicBy)
            .And(this.NumberOfEpisodes)
            .And(this.NumberOfPlayers)
            .And(this.NumberOfSeasons)
            .And(this.PlayMode)
            .And(this.ProductionCompany)
            .And(this.Quest)
            .And(this.Trailer)
            .And(base.GetHashCode());
    }
}
