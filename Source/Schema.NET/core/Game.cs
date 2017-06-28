namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

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
        [DataMember(Name = "characterAttribute", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? CharacterAttribute { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, Place, PostalAddress>? GameLocation { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? NumberOfPlayers { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Quest { get; set; }
    }
}
