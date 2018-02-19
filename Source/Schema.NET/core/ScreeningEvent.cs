using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    [DataContract]
    public partial class ScreeningEvent : Event
    {
        public interface ISubtitleLanguage : IWrapper { }
        public interface ISubtitleLanguage<T> : ISubtitleLanguage { new T Data { get; set; } }
        public class SubtitleLanguageLanguage : ISubtitleLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public SubtitleLanguageLanguage () { }
            public SubtitleLanguageLanguage (Language data) { Data = data; }
            public static implicit operator SubtitleLanguageLanguage (Language data) { return new SubtitleLanguageLanguage (data); }
        }

        public class SubtitleLanguagestring : ISubtitleLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public SubtitleLanguagestring () { }
            public SubtitleLanguagestring (string data) { Data = data; }
            public static implicit operator SubtitleLanguagestring (string data) { return new SubtitleLanguagestring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ScreeningEvent";

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISubtitleLanguage>? SubtitleLanguage { get; set; } //Language, string

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VideoFormat { get; set; } 

        /// <summary>
        /// The movie presented during this event.
        /// </summary>
        [DataMember(Name = "workPresented", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Movie>? WorkPresented { get; set; } 
    }
}
