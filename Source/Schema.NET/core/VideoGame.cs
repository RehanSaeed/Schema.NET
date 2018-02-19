using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    [DataContract]
    public partial class VideoGame : GameAndSoftwareApplication
    {
        public interface IGamePlatform : IWrapper { }
        public interface IGamePlatform<T> : IGamePlatform { new T Data { get; set; } }
        public class GamePlatformstring : IGamePlatform<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public GamePlatformstring () { }
            public GamePlatformstring (string data) { Data = data; }
            public static implicit operator GamePlatformstring (string data) { return new GamePlatformstring (data); }
        }

        public class GamePlatformThing : IGamePlatform<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public GamePlatformThing () { }
            public GamePlatformThing (Thing data) { Data = data; }
            public static implicit operator GamePlatformThing (Thing data) { return new GamePlatformThing (data); }
        }

        public class GamePlatformUri : IGamePlatform<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public GamePlatformUri () { }
            public GamePlatformUri (Uri data) { Data = data; }
            public static implicit operator GamePlatformUri (Uri data) { return new GamePlatformUri (data); }
        }


        public interface IMusicBy : IWrapper { }
        public interface IMusicBy<T> : IMusicBy { new T Data { get; set; } }
        public class MusicByMusicGroup : IMusicBy<MusicGroup>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MusicGroup) value; } }
            public virtual MusicGroup Data { get; set; }
            public MusicByMusicGroup () { }
            public MusicByMusicGroup (MusicGroup data) { Data = data; }
            public static implicit operator MusicByMusicGroup (MusicGroup data) { return new MusicByMusicGroup (data); }
        }

        public class MusicByPerson : IMusicBy<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public MusicByPerson () { }
            public MusicByPerson (Person data) { Data = data; }
            public static implicit operator MusicByPerson (Person data) { return new MusicByPerson (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; } 

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? CheatCode { get; set; } 

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; } 

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGamePlatform>? GamePlatform { get; set; } //string, Thing, Uri

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        [DataMember(Name = "gameServer", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GameServer>? GameServer { get; set; } 

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        [DataMember(Name = "gameTip", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? GameTip { get; set; } 

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicBy>? MusicBy { get; set; } //MusicGroup, Person

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GamePlayMode>? PlayMode { get; set; } 

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Trailer { get; set; } 
    }
}
