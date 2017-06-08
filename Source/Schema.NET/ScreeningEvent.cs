namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    [DataContract]
    public class ScreeningEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ScreeningEvent";

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat")]
        public string VideoFormat { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage")]
        public object SubtitleLanguage { get; protected set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string SubtitleLanguageText
        {
            get => this.SubtitleLanguage as string;
            set => this.SubtitleLanguage = value;
        }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Language SubtitleLanguageLanguage
        {
            get => this.SubtitleLanguage as Language;
            set => this.SubtitleLanguage = value;
        }

        /// <summary>
        /// The movie presented during this event.
        /// </summary>
        [DataMember(Name = "workPresented")]
        public Movie WorkPresented { get; set; }
    }
}
