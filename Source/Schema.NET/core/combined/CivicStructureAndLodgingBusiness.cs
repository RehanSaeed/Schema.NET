namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See CivicStructure, LodgingBusiness for more information.
    /// </summary>
    public partial interface ICivicStructureAndLodgingBusiness : ICivicStructure, ILodgingBusiness
    {
    }

    /// <summary>
    /// See CivicStructure, LodgingBusiness for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CivicStructureAndLodgingBusiness : LocalBusinessAndPlace, ICivicStructureAndLodgingBusiness, IEquatable<CivicStructureAndLodgingBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CivicStructureAndLodgingBusiness";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> CheckoutTime { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> OpeningHours { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string> PetsAllowed { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> StarRating { get; set; }

        /// <inheritdoc/>
        public bool Equals(CivicStructureAndLodgingBusiness other)
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
                this.AmenityFeature == other.AmenityFeature &&
                this.Audience == other.Audience &&
                this.AvailableLanguage == other.AvailableLanguage &&
                this.CheckinTime == other.CheckinTime &&
                this.CheckoutTime == other.CheckoutTime &&
                this.NumberOfRooms == other.NumberOfRooms &&
                this.OpeningHours == other.OpeningHours &&
                this.PetsAllowed == other.PetsAllowed &&
                this.StarRating == other.StarRating &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CivicStructureAndLodgingBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AmenityFeature)
            .And(this.Audience)
            .And(this.AvailableLanguage)
            .And(this.CheckinTime)
            .And(this.CheckoutTime)
            .And(this.NumberOfRooms)
            .And(this.OpeningHours)
            .And(this.PetsAllowed)
            .And(this.StarRating)
            .And(base.GetHashCode());
    }
}
