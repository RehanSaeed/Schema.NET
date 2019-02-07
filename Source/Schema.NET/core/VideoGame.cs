namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    [DataContract]
    public partial class VideoGame : GameAndSoftwareApplication
    {
        public interface IActor : IValue {}
        public interface IActor<T> : IActor { new T Value { get; } }
        public class OneOrManyActor : OneOrMany<IActor>
        {
            public OneOrManyActor(IActor item) : base(item) { }
            public OneOrManyActor(IEnumerable<IActor> items) : base(items) { }
            public static implicit operator OneOrManyActor (Person value) { return new OneOrManyActor (new ActorPerson (value)); }
            public static implicit operator OneOrManyActor (Person[] values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
            public static implicit operator OneOrManyActor (List<Person> values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
        }
        public struct ActorPerson : IActor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ActorPerson (Person value) { Value = value; }
            public static implicit operator ActorPerson (Person value) { return new ActorPerson (value); }
        }

        public interface ICheatCode : IValue {}
        public interface ICheatCode<T> : ICheatCode { new T Value { get; } }
        public class OneOrManyCheatCode : OneOrMany<ICheatCode>
        {
            public OneOrManyCheatCode(ICheatCode item) : base(item) { }
            public OneOrManyCheatCode(IEnumerable<ICheatCode> items) : base(items) { }
            public static implicit operator OneOrManyCheatCode (CreativeWork value) { return new OneOrManyCheatCode (new CheatCodeCreativeWork (value)); }
            public static implicit operator OneOrManyCheatCode (CreativeWork[] values) { return new OneOrManyCheatCode (values.Select(v => (ICheatCode) new CheatCodeCreativeWork (v))); }
            public static implicit operator OneOrManyCheatCode (List<CreativeWork> values) { return new OneOrManyCheatCode (values.Select(v => (ICheatCode) new CheatCodeCreativeWork (v))); }
        }
        public struct CheatCodeCreativeWork : ICheatCode<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public CheatCodeCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator CheatCodeCreativeWork (CreativeWork value) { return new CheatCodeCreativeWork (value); }
        }

        public interface IDirector : IValue {}
        public interface IDirector<T> : IDirector { new T Value { get; } }
        public class OneOrManyDirector : OneOrMany<IDirector>
        {
            public OneOrManyDirector(IDirector item) : base(item) { }
            public OneOrManyDirector(IEnumerable<IDirector> items) : base(items) { }
            public static implicit operator OneOrManyDirector (Person value) { return new OneOrManyDirector (new DirectorPerson (value)); }
            public static implicit operator OneOrManyDirector (Person[] values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
            public static implicit operator OneOrManyDirector (List<Person> values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
        }
        public struct DirectorPerson : IDirector<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public DirectorPerson (Person value) { Value = value; }
            public static implicit operator DirectorPerson (Person value) { return new DirectorPerson (value); }
        }

        public interface IGamePlatform : IValue {}
        public interface IGamePlatform<T> : IGamePlatform { new T Value { get; } }
        public class OneOrManyGamePlatform : OneOrMany<IGamePlatform>
        {
            public OneOrManyGamePlatform(IGamePlatform item) : base(item) { }
            public OneOrManyGamePlatform(IEnumerable<IGamePlatform> items) : base(items) { }
            public static implicit operator OneOrManyGamePlatform (string value) { return new OneOrManyGamePlatform (new GamePlatformstring (value)); }
            public static implicit operator OneOrManyGamePlatform (string[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformstring (v))); }
            public static implicit operator OneOrManyGamePlatform (List<string> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformstring (v))); }
            public static implicit operator OneOrManyGamePlatform (Thing value) { return new OneOrManyGamePlatform (new GamePlatformThing (value)); }
            public static implicit operator OneOrManyGamePlatform (Thing[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformThing (v))); }
            public static implicit operator OneOrManyGamePlatform (List<Thing> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformThing (v))); }
            public static implicit operator OneOrManyGamePlatform (Uri value) { return new OneOrManyGamePlatform (new GamePlatformUri (value)); }
            public static implicit operator OneOrManyGamePlatform (Uri[] values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformUri (v))); }
            public static implicit operator OneOrManyGamePlatform (List<Uri> values) { return new OneOrManyGamePlatform (values.Select(v => (IGamePlatform) new GamePlatformUri (v))); }
        }
        public struct GamePlatformstring : IGamePlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public GamePlatformstring (string value) { Value = value; }
            public static implicit operator GamePlatformstring (string value) { return new GamePlatformstring (value); }
        }
        public struct GamePlatformThing : IGamePlatform<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public GamePlatformThing (Thing value) { Value = value; }
            public static implicit operator GamePlatformThing (Thing value) { return new GamePlatformThing (value); }
        }
        public struct GamePlatformUri : IGamePlatform<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GamePlatformUri (Uri value) { Value = value; }
            public static implicit operator GamePlatformUri (Uri value) { return new GamePlatformUri (value); }
        }

        public interface IGameServer : IValue {}
        public interface IGameServer<T> : IGameServer { new T Value { get; } }
        public class OneOrManyGameServer : OneOrMany<IGameServer>
        {
            public OneOrManyGameServer(IGameServer item) : base(item) { }
            public OneOrManyGameServer(IEnumerable<IGameServer> items) : base(items) { }
            public static implicit operator OneOrManyGameServer (GameServer value) { return new OneOrManyGameServer (new GameServerGameServer (value)); }
            public static implicit operator OneOrManyGameServer (GameServer[] values) { return new OneOrManyGameServer (values.Select(v => (IGameServer) new GameServerGameServer (v))); }
            public static implicit operator OneOrManyGameServer (List<GameServer> values) { return new OneOrManyGameServer (values.Select(v => (IGameServer) new GameServerGameServer (v))); }
        }
        public struct GameServerGameServer : IGameServer<GameServer>
        {
            object IValue.Value => this.Value;
            public GameServer Value { get; }
            public GameServerGameServer (GameServer value) { Value = value; }
            public static implicit operator GameServerGameServer (GameServer value) { return new GameServerGameServer (value); }
        }

        public interface IGameTip : IValue {}
        public interface IGameTip<T> : IGameTip { new T Value { get; } }
        public class OneOrManyGameTip : OneOrMany<IGameTip>
        {
            public OneOrManyGameTip(IGameTip item) : base(item) { }
            public OneOrManyGameTip(IEnumerable<IGameTip> items) : base(items) { }
            public static implicit operator OneOrManyGameTip (CreativeWork value) { return new OneOrManyGameTip (new GameTipCreativeWork (value)); }
            public static implicit operator OneOrManyGameTip (CreativeWork[] values) { return new OneOrManyGameTip (values.Select(v => (IGameTip) new GameTipCreativeWork (v))); }
            public static implicit operator OneOrManyGameTip (List<CreativeWork> values) { return new OneOrManyGameTip (values.Select(v => (IGameTip) new GameTipCreativeWork (v))); }
        }
        public struct GameTipCreativeWork : IGameTip<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public GameTipCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator GameTipCreativeWork (CreativeWork value) { return new GameTipCreativeWork (value); }
        }

        public interface IMusicBy : IValue {}
        public interface IMusicBy<T> : IMusicBy { new T Value { get; } }
        public class OneOrManyMusicBy : OneOrMany<IMusicBy>
        {
            public OneOrManyMusicBy(IMusicBy item) : base(item) { }
            public OneOrManyMusicBy(IEnumerable<IMusicBy> items) : base(items) { }
            public static implicit operator OneOrManyMusicBy (MusicGroup value) { return new OneOrManyMusicBy (new MusicByMusicGroup (value)); }
            public static implicit operator OneOrManyMusicBy (MusicGroup[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (List<MusicGroup> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (Person value) { return new OneOrManyMusicBy (new MusicByPerson (value)); }
            public static implicit operator OneOrManyMusicBy (Person[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
            public static implicit operator OneOrManyMusicBy (List<Person> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
        }
        public struct MusicByMusicGroup : IMusicBy<MusicGroup>
        {
            object IValue.Value => this.Value;
            public MusicGroup Value { get; }
            public MusicByMusicGroup (MusicGroup value) { Value = value; }
            public static implicit operator MusicByMusicGroup (MusicGroup value) { return new MusicByMusicGroup (value); }
        }
        public struct MusicByPerson : IMusicBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public MusicByPerson (Person value) { Value = value; }
            public static implicit operator MusicByPerson (Person value) { return new MusicByPerson (value); }
        }

        public interface IPlayMode : IValue {}
        public interface IPlayMode<T> : IPlayMode { new T Value { get; } }
        public class OneOrManyPlayMode : OneOrMany<IPlayMode>
        {
            public OneOrManyPlayMode(IPlayMode item) : base(item) { }
            public OneOrManyPlayMode(IEnumerable<IPlayMode> items) : base(items) { }
            public static implicit operator OneOrManyPlayMode (GamePlayMode value) { return new OneOrManyPlayMode (new PlayModeGamePlayMode (value)); }
            public static implicit operator OneOrManyPlayMode (GamePlayMode[] values) { return new OneOrManyPlayMode (values.Select(v => (IPlayMode) new PlayModeGamePlayMode (v))); }
            public static implicit operator OneOrManyPlayMode (List<GamePlayMode> values) { return new OneOrManyPlayMode (values.Select(v => (IPlayMode) new PlayModeGamePlayMode (v))); }
        }
        public struct PlayModeGamePlayMode : IPlayMode<GamePlayMode>
        {
            object IValue.Value => this.Value;
            public GamePlayMode Value { get; }
            public PlayModeGamePlayMode (GamePlayMode value) { Value = value; }
            public static implicit operator PlayModeGamePlayMode (GamePlayMode value) { return new PlayModeGamePlayMode (value); }
        }

        public interface ITrailer : IValue {}
        public interface ITrailer<T> : ITrailer { new T Value { get; } }
        public class OneOrManyTrailer : OneOrMany<ITrailer>
        {
            public OneOrManyTrailer(ITrailer item) : base(item) { }
            public OneOrManyTrailer(IEnumerable<ITrailer> items) : base(items) { }
            public static implicit operator OneOrManyTrailer (VideoObject value) { return new OneOrManyTrailer (new TrailerVideoObject (value)); }
            public static implicit operator OneOrManyTrailer (VideoObject[] values) { return new OneOrManyTrailer (values.Select(v => (ITrailer) new TrailerVideoObject (v))); }
            public static implicit operator OneOrManyTrailer (List<VideoObject> values) { return new OneOrManyTrailer (values.Select(v => (ITrailer) new TrailerVideoObject (v))); }
        }
        public struct TrailerVideoObject : ITrailer<VideoObject>
        {
            object IValue.Value => this.Value;
            public VideoObject Value { get; }
            public TrailerVideoObject (VideoObject value) { Value = value; }
            public static implicit operator TrailerVideoObject (VideoObject value) { return new TrailerVideoObject (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGame";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 307)]
        public OneOrManyCheatCode CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 309)]
        public OneOrManyGamePlatform GamePlatform { get; set; }

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        [DataMember(Name = "gameServer", Order = 310)]
        public OneOrManyGameServer GameServer { get; set; }

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        [DataMember(Name = "gameTip", Order = 311)]
        public OneOrManyGameTip GameTip { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 312)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 313)]
        public OneOrManyPlayMode PlayMode { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 314)]
        public OneOrManyTrailer Trailer { get; set; }
    }
}
