namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    [DataContract]
    public class LodgingBusiness : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingBusiness";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 2)]
        public LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 3)]
        public Audience Audience { get; set; }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 4)]
        public object AvailableLanguage { get; protected set; }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [IgnoreDataMember]
        public string AvailableLanguageText
        {
            get => this.AvailableLanguage as string;
            set => this.AvailableLanguage = value;
        }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [IgnoreDataMember]
        public Language AvailableLanguageLanguage
        {
            get => this.AvailableLanguage as Language;
            set => this.AvailableLanguage = value;
        }

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 5)]
        public DateTimeOffset? CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 6)]
        public DateTimeOffset? CheckoutTime { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 7)]
        public object PetsAllowed { get; protected set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [IgnoreDataMember]
        public string PetsAllowedText
        {
            get => this.PetsAllowed as string;
            set => this.PetsAllowed = value;
        }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [IgnoreDataMember]
        public bool? PetsAllowedBoolean
        {
            get => this.PetsAllowed as bool?;
            set => this.PetsAllowed = value;
        }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 8)]
        public Rating StarRating { get; set; }
    }
}
