namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    public partial interface ITVEpisode : IEpisode
    {
        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        OneOrMany<ICountry> CountryOfOrigin { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> SubtitleLanguage { get; set; }
    }

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class TVEpisode : Episode, ITVEpisode, IEquatable<TVEpisode>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVEpisode";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> CountryOfOrigin { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <inheritdoc/>
        public bool Equals(TVEpisode other)
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
                this.CountryOfOrigin == other.CountryOfOrigin &&
                this.SubtitleLanguage == other.SubtitleLanguage &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TVEpisode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CountryOfOrigin)
            .And(this.SubtitleLanguage)
            .And(base.GetHashCode());
    }
}
