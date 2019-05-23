namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    public partial interface IGameServer : IIntangible
    {
        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        OneOrMany<IVideoGame> Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        OneOrMany<int?> PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        OneOrMany<GameServerStatus?> ServerStatus { get; set; }
    }

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    [DataContract]
    public partial class GameServer : Intangible, IGameServer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GameServer";

        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        [DataMember(Name = "game", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoGame> Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        [DataMember(Name = "playersOnline", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        [DataMember(Name = "serverStatus", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<GameServerStatus?> ServerStatus { get; set; }
    }
}
