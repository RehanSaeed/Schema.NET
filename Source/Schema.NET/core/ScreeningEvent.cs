namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    public partial interface IScreeningEvent : IEvent
    {
        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string>? SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }

        /// <summary>
        /// The movie presented during this event.
        /// </summary>
        OneOrMany<IMovie> WorkPresented { get; set; }
    }

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    [DataContract]
    public partial class ScreeningEvent : Event, IScreeningEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ScreeningEvent";

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string>? SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }

        /// <summary>
        /// The movie presented during this event.
        /// </summary>
        [DataMember(Name = "workPresented", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMovie> WorkPresented { get; set; }
    }
}
