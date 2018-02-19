using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    [DataContract]
    public partial class LodgingBusiness : LocalBusiness
    {
        public interface IAvailableLanguage : IWrapper { }
        public interface IAvailableLanguage<T> : IAvailableLanguage { new T Data { get; set; } }
        public class AvailableLanguageLanguage : IAvailableLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public AvailableLanguageLanguage () { }
            public AvailableLanguageLanguage (Language data) { Data = data; }
            public static implicit operator AvailableLanguageLanguage (Language data) { return new AvailableLanguageLanguage (data); }
        }

        public class AvailableLanguagestring : IAvailableLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AvailableLanguagestring () { }
            public AvailableLanguagestring (string data) { Data = data; }
            public static implicit operator AvailableLanguagestring (string data) { return new AvailableLanguagestring (data); }
        }


        public interface IPetsAllowed : IWrapper { }
        public interface IPetsAllowed<T> : IPetsAllowed { new T Data { get; set; } }
        public class PetsAllowedbool : IPetsAllowed<bool>
        {
            object IWrapper.Data { get { return Data; } set { Data = (bool) value; } }
            public virtual bool Data { get; set; }
            public PetsAllowedbool () { }
            public PetsAllowedbool (bool data) { Data = data; }
            public static implicit operator PetsAllowedbool (bool data) { return new PetsAllowedbool (data); }
        }

        public class PetsAllowedstring : IPetsAllowed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PetsAllowedstring () { }
            public PetsAllowedstring (string data) { Data = data; }
            public static implicit operator PetsAllowedstring (string data) { return new PetsAllowedstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingBusiness";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<LocationFeatureSpecification>? AmenityFeature { get; set; } 

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; } 

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAvailableLanguage>? AvailableLanguage { get; set; } //Language, string

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? CheckinTime { get; set; } 

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? CheckoutTime { get; set; } 

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPetsAllowed>? PetsAllowed { get; set; } //bool?, string

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Rating>? StarRating { get; set; } 
    }
}
