namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A movie.
    /// </summary>
    public partial interface IMovie : ICreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        OneOrMany<ICountry> CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// An &lt;a href="https://eidr.org/"&gt;EIDR&lt;/a&gt; (Entertainment Identifier Registry) &lt;a class="localLink" href="https://schema.org/identifier"&gt;identifier&lt;/a&gt; representing at the most general/abstract level, a work of film or television.&lt;br/&gt;&lt;br/&gt;
        /// For example, the motion picture known as "Ghostbusters" has a titleEIDR of  "10.5240/7EC7-228A-510A-053E-CBB8-J". This title (or work) may have several variants, which EIDR calls "edits". See &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Since schema.org types like &lt;a class="localLink" href="https://schema.org/Movie"&gt;Movie&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/TVEpisode"&gt;TVEpisode&lt;/a&gt; can be used for both works and their multiple expressions, it is possible to use &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; alone (for a general description), or alongside &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt; for a more edit-specific description.
        /// </summary>
        Values<string, Uri> TitleEIDR { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject> Trailer { get; set; }
    }

    /// <summary>
    /// A movie.
    /// </summary>
    [DataContract]
    public partial class Movie : CreativeWork, IMovie, IEquatable<Movie>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Movie";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 209)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// An &lt;a href="https://eidr.org/"&gt;EIDR&lt;/a&gt; (Entertainment Identifier Registry) &lt;a class="localLink" href="https://schema.org/identifier"&gt;identifier&lt;/a&gt; representing at the most general/abstract level, a work of film or television.&lt;br/&gt;&lt;br/&gt;
        /// For example, the motion picture known as "Ghostbusters" has a titleEIDR of  "10.5240/7EC7-228A-510A-053E-CBB8-J". This title (or work) may have several variants, which EIDR calls "edits". See &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Since schema.org types like &lt;a class="localLink" href="https://schema.org/Movie"&gt;Movie&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/TVEpisode"&gt;TVEpisode&lt;/a&gt; can be used for both works and their multiple expressions, it is possible to use &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; alone (for a general description), or alongside &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt; for a more edit-specific description.
        /// </summary>
        [DataMember(Name = "titleEIDR", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> TitleEIDR { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }

        /// <inheritdoc/>
        public bool Equals(Movie other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.Actor == other.Actor &&
                this.CountryOfOrigin == other.CountryOfOrigin &&
                this.Director == other.Director &&
                this.Duration == other.Duration &&
                this.MusicBy == other.MusicBy &&
                this.ProductionCompany == other.ProductionCompany &&
                this.SubtitleLanguage == other.SubtitleLanguage &&
                this.TitleEIDR == other.TitleEIDR &&
                this.Trailer == other.Trailer &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Movie);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.CountryOfOrigin)
            .And(this.Director)
            .And(this.Duration)
            .And(this.MusicBy)
            .And(this.ProductionCompany)
            .And(this.SubtitleLanguage)
            .And(this.TitleEIDR)
            .And(this.Trailer)
            .And(base.GetHashCode());
    }
}
