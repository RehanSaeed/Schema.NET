using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
    [DataContract]
    public partial class Game : CreativeWork
    {
        public interface IGameLocation : IWrapper { }
        public interface IGameLocation<T> : IGameLocation { new T Data { get; set; } }
        public class GameLocationPlace : IGameLocation<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public GameLocationPlace () { }
            public GameLocationPlace (Place data) { Data = data; }
            public static implicit operator GameLocationPlace (Place data) { return new GameLocationPlace (data); }
        }

        public class GameLocationPostalAddress : IGameLocation<PostalAddress>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PostalAddress) value; } }
            public virtual PostalAddress Data { get; set; }
            public GameLocationPostalAddress () { }
            public GameLocationPostalAddress (PostalAddress data) { Data = data; }
            public static implicit operator GameLocationPostalAddress (PostalAddress data) { return new GameLocationPostalAddress (data); }
        }

        public class GameLocationUri : IGameLocation<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public GameLocationUri () { }
            public GameLocationUri (Uri data) { Data = data; }
            public static implicit operator GameLocationUri (Uri data) { return new GameLocationUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Game";

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? CharacterAttribute { get; set; } 

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? GameItem { get; set; } 

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGameLocation>? GameLocation { get; set; } //Place, PostalAddress, Uri

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? NumberOfPlayers { get; set; } 

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Quest { get; set; } 
    }
}
