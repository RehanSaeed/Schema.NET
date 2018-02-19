using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class TVEpisode : Episode
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
        public override string Type => "TVEpisode";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country>? CountryOfOrigin { get; set; } 

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISubtitleLanguage>? SubtitleLanguage { get; set; } //Language, string
    }
}
