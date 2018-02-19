using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract]
    public partial class VideoObject : MediaObject
    {
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
        public override string Type => "VideoObject";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; } 

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Caption { get; set; } 

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; } 

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicBy>? MusicBy { get; set; } //MusicGroup, Person

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject>? Thumbnail { get; set; } 

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Transcript { get; set; } 

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [DataMember(Name = "videoFrameSize", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VideoFrameSize { get; set; } 

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [DataMember(Name = "videoQuality", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VideoQuality { get; set; } 
    }
}
