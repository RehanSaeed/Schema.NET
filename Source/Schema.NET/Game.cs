namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e...
    /// </summary>
    [DataContract]
    public class Game : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Game";

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem")]
        public Thing GameItem { get; set; }

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
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest")]
        public Thing Quest { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers")]
        public QuantitativeValue NumberOfPlayers { get; set; }
    }
}
