namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    [DataContract]
    public class GameServer : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GameServer";

        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        [DataMember(Name = "game")]
        public VideoGame Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        [DataMember(Name = "playersOnline")]
        public int PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        [DataMember(Name = "serverStatus")]
        public GameServerStatus ServerStatus { get; set; }
    }
}
