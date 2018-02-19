using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    [DataContract]
    public partial class Clip : CreativeWork
    {
        public interface IClipNumber : IWrapper { }
        public interface IClipNumber<T> : IClipNumber { new T Data { get; set; } }
        public class ClipNumberint : IClipNumber<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public ClipNumberint () { }
            public ClipNumberint (int data) { Data = data; }
            public static implicit operator ClipNumberint (int data) { return new ClipNumberint (data); }
        }

        public class ClipNumberstring : IClipNumber<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ClipNumberstring () { }
            public ClipNumberstring (string data) { Data = data; }
            public static implicit operator ClipNumberstring (string data) { return new ClipNumberstring (data); }
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
        public override string Type => "Clip";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; } 

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [DataMember(Name = "clipNumber", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IClipNumber>? ClipNumber { get; set; } //int?, string

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; } 

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicBy>? MusicBy { get; set; } //MusicGroup, Person

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Episode>? PartOfEpisode { get; set; } 

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeason>? PartOfSeason { get; set; } 

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeries>? PartOfSeries { get; set; } 
    }
}
