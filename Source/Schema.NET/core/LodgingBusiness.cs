namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    public partial interface ILodgingBusiness : ILocalBusiness
    {
        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> CheckoutTime { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        Values<bool?, string> PetsAllowed { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        OneOrMany<IRating> StarRating { get; set; }
    }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    [DataContract]
    public partial class LodgingBusiness : LocalBusiness, ILodgingBusiness, IEquatable<LodgingBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingBusiness";

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
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string> PetsAllowed { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> StarRating { get; set; }

        /// <inheritdoc/>
        public bool Equals(LodgingBusiness other)
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
                this.PetsAllowed == other.PetsAllowed &&
                this.StarRating == other.StarRating &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as LodgingBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AmenityFeature)
            .And(this.Audience)
            .And(this.AvailableLanguage)
            .And(this.CheckinTime)
            .And(this.CheckoutTime)
            .And(this.NumberOfRooms)
            .And(this.PetsAllowed)
            .And(this.StarRating)
            .And(base.GetHashCode());
    }
}
