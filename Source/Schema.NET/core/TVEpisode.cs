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

        /// <summary>
        /// An &lt;a href="https://eidr.org/"&gt;EIDR&lt;/a&gt; (Entertainment Identifier Registry) &lt;a class="localLink" href="https://schema.org/identifier"&gt;identifier&lt;/a&gt; representing at the most general/abstract level, a work of film or television.&lt;br/&gt;&lt;br/&gt;
        /// For example, the motion picture known as "Ghostbusters" has a titleEIDR of  "10.5240/7EC7-228A-510A-053E-CBB8-J". This title (or work) may have several variants, which EIDR calls "edits". See &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Since schema.org types like &lt;a class="localLink" href="https://schema.org/Movie"&gt;Movie&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/TVEpisode"&gt;TVEpisode&lt;/a&gt; can be used for both works and their multiple expressions, it is possible to use &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; alone (for a general description), or alongside &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt; for a more edit-specific description.
        /// </summary>
        Values<string, Uri> TitleEIDR { get; set; }
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

        /// <summary>
        /// An &lt;a href="https://eidr.org/"&gt;EIDR&lt;/a&gt; (Entertainment Identifier Registry) &lt;a class="localLink" href="https://schema.org/identifier"&gt;identifier&lt;/a&gt; representing at the most general/abstract level, a work of film or television.&lt;br/&gt;&lt;br/&gt;
        /// For example, the motion picture known as "Ghostbusters" has a titleEIDR of  "10.5240/7EC7-228A-510A-053E-CBB8-J". This title (or work) may have several variants, which EIDR calls "edits". See &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Since schema.org types like &lt;a class="localLink" href="https://schema.org/Movie"&gt;Movie&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/TVEpisode"&gt;TVEpisode&lt;/a&gt; can be used for both works and their multiple expressions, it is possible to use &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; alone (for a general description), or alongside &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt; for a more edit-specific description.
        /// </summary>
        [DataMember(Name = "titleEIDR", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> TitleEIDR { get; set; }

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
                this.TitleEIDR == other.TitleEIDR &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TVEpisode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CountryOfOrigin)
            .And(this.SubtitleLanguage)
            .And(this.TitleEIDR)
            .And(base.GetHashCode());
    }
}
