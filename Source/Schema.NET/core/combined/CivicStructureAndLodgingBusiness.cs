using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See CivicStructure, LodgingBusiness for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CivicStructureAndLodgingBusiness : LocalBusinessAndPlace
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
        public override string Type => "CivicStructureAndLodgingBusiness";

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
        /// &lt;p&gt;The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? OpeningHours { get; set; } 

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPetsAllowed>? PetsAllowed { get; set; } //bool?, string

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Rating>? StarRating { get; set; } 
    }
}
