namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    [DataContract]
    public partial class GameServer : Intangible
    {
        public interface IGame : IValue {}
        public interface IGame<T> : IGame { new T Value { get; } }
        public class OneOrManyGame : OneOrMany<IGame>
        {
            public OneOrManyGame(IGame item) : base(item) { }
            public OneOrManyGame(IEnumerable<IGame> items) : base(items) { }
            public static implicit operator OneOrManyGame (VideoGame value) { return new OneOrManyGame (new GameVideoGame (value)); }
            public static implicit operator OneOrManyGame (VideoGame[] values) { return new OneOrManyGame (values.Select(v => (IGame) new GameVideoGame (v))); }
            public static implicit operator OneOrManyGame (List<VideoGame> values) { return new OneOrManyGame (values.Select(v => (IGame) new GameVideoGame (v))); }
        }
        public struct GameVideoGame : IGame<VideoGame>
        {
            object IValue.Value => this.Value;
            public VideoGame Value { get; }
            public GameVideoGame (VideoGame value) { Value = value; }
            public static implicit operator GameVideoGame (VideoGame value) { return new GameVideoGame (value); }
        }

        public interface IPlayersOnline : IValue {}
        public interface IPlayersOnline<T> : IPlayersOnline { new T Value { get; } }
        public class OneOrManyPlayersOnline : OneOrMany<IPlayersOnline>
        {
            public OneOrManyPlayersOnline(IPlayersOnline item) : base(item) { }
            public OneOrManyPlayersOnline(IEnumerable<IPlayersOnline> items) : base(items) { }
            public static implicit operator OneOrManyPlayersOnline (int value) { return new OneOrManyPlayersOnline (new PlayersOnlineint (value)); }
            public static implicit operator OneOrManyPlayersOnline (int[] values) { return new OneOrManyPlayersOnline (values.Select(v => (IPlayersOnline) new PlayersOnlineint (v))); }
            public static implicit operator OneOrManyPlayersOnline (List<int> values) { return new OneOrManyPlayersOnline (values.Select(v => (IPlayersOnline) new PlayersOnlineint (v))); }
        }
        public struct PlayersOnlineint : IPlayersOnline<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PlayersOnlineint (int value) { Value = value; }
            public static implicit operator PlayersOnlineint (int value) { return new PlayersOnlineint (value); }
        }

        public interface IServerStatus : IValue {}
        public interface IServerStatus<T> : IServerStatus { new T Value { get; } }
        public class OneOrManyServerStatus : OneOrMany<IServerStatus>
        {
            public OneOrManyServerStatus(IServerStatus item) : base(item) { }
            public OneOrManyServerStatus(IEnumerable<IServerStatus> items) : base(items) { }
            public static implicit operator OneOrManyServerStatus (GameServerStatus value) { return new OneOrManyServerStatus (new ServerStatusGameServerStatus (value)); }
            public static implicit operator OneOrManyServerStatus (GameServerStatus[] values) { return new OneOrManyServerStatus (values.Select(v => (IServerStatus) new ServerStatusGameServerStatus (v))); }
            public static implicit operator OneOrManyServerStatus (List<GameServerStatus> values) { return new OneOrManyServerStatus (values.Select(v => (IServerStatus) new ServerStatusGameServerStatus (v))); }
        }
        public struct ServerStatusGameServerStatus : IServerStatus<GameServerStatus>
        {
            object IValue.Value => this.Value;
            public GameServerStatus Value { get; }
            public ServerStatusGameServerStatus (GameServerStatus value) { Value = value; }
            public static implicit operator ServerStatusGameServerStatus (GameServerStatus value) { return new ServerStatusGameServerStatus (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GameServer";

        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        [DataMember(Name = "game", Order = 206)]
        public OneOrManyGame Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        [DataMember(Name = "playersOnline", Order = 207)]
        public OneOrManyPlayersOnline PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        [DataMember(Name = "serverStatus", Order = 208)]
        public OneOrManyServerStatus ServerStatus { get; set; }
    }
}
