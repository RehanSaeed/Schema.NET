namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    [DataContract]
    public partial class GameServer : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GameServer";

        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        [DataMember(Name = "game", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoGame>? Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        [DataMember(Name = "playersOnline", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        [DataMember(Name = "serverStatus", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GameServerStatus?>? ServerStatus { get; set; }
    }
}
