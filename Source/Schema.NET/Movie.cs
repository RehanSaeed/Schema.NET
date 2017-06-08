namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A movie.
    /// </summary>
    [DataContract]
    public class Movie : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Movie";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer")]
        public VideoObject Trailer { get; set; }

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

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy")]
        public object MusicBy { get; protected set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public Person MusicByPerson
        {
            get => this.MusicBy as Person;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public MusicGroup MusicByMusicGroup
        {
            get => this.MusicBy as MusicGroup;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration")]
        public Duration Duration { get; set; }
    }
}
