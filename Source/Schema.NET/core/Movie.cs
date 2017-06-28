namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A movie.
    /// </summary>
    [DataContract]
    public partial class Movie : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Movie";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country>? CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 208)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, MusicGroup>? MusicBy { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? ProductionCompany { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Language>? SubtitleLanguage { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Trailer { get; set; }
    }
}
