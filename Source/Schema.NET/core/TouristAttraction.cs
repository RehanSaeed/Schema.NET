namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="https://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="https://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="https://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="https://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// </summary>
    public partial interface ITouristAttraction : IPlace
    {
        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        Values<IAudience, string> TouristType { get; set; }
    }

    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="https://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="https://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="https://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="https://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// </summary>
    [DataContract]
    public partial class TouristAttraction : Place, ITouristAttraction, IEquatable<TouristAttraction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TouristAttraction";

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        [DataMember(Name = "touristType", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, string> TouristType { get; set; }

        /// <inheritdoc/>
        public bool Equals(TouristAttraction other)
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
                this.AvailableLanguage == other.AvailableLanguage &&
                this.TouristType == other.TouristType &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TouristAttraction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AvailableLanguage)
            .And(this.TouristType)
            .And(base.GetHashCode());
    }
}
