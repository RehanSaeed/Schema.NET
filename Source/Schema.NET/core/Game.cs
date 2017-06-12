namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e...
    /// </summary>
    [DataContract]
    public partial class Game : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Game";

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 2)]
        public Thing CharacterAttribute { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 3)]
        public Thing GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 4)]
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
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 5)]
        public QuantitativeValue NumberOfPlayers { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 6)]
        public Thing Quest { get; set; }
    }
}
