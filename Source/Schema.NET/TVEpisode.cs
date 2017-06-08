namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public class TVEpisode : Episode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TVEpisode";

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
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin")]
        public Country CountryOfOrigin { get; set; }
    }
}
