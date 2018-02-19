using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    [DataContract]
    public partial class ContactPoint : StructuredValue
    {
        public interface IAreaServed : IWrapper { }
        public interface IAreaServed<T> : IAreaServed { new T Data { get; set; } }
        public class AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AdministrativeArea) value; } }
            public virtual AdministrativeArea Data { get; set; }
            public AreaServedAdministrativeArea () { }
            public AreaServedAdministrativeArea (AdministrativeArea data) { Data = data; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea data) { return new AreaServedAdministrativeArea (data); }
        }

        public class AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public AreaServedGeoShape () { }
            public AreaServedGeoShape (GeoShape data) { Data = data; }
            public static implicit operator AreaServedGeoShape (GeoShape data) { return new AreaServedGeoShape (data); }
        }

        public class AreaServedPlace : IAreaServed<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public AreaServedPlace () { }
            public AreaServedPlace (Place data) { Data = data; }
            public static implicit operator AreaServedPlace (Place data) { return new AreaServedPlace (data); }
        }

        public class AreaServedstring : IAreaServed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AreaServedstring () { }
            public AreaServedstring (string data) { Data = data; }
            public static implicit operator AreaServedstring (string data) { return new AreaServedstring (data); }
        }


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


        public interface IProductSupported : IWrapper { }
        public interface IProductSupported<T> : IProductSupported { new T Data { get; set; } }
        public class ProductSupportedProduct : IProductSupported<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public ProductSupportedProduct () { }
            public ProductSupportedProduct (Product data) { Data = data; }
            public static implicit operator ProductSupportedProduct (Product data) { return new ProductSupportedProduct (data); }
        }

        public class ProductSupportedstring : IProductSupported<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ProductSupportedstring () { }
            public ProductSupportedstring (string data) { Data = data; }
            public static implicit operator ProductSupportedstring (string data) { return new ProductSupportedstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPoint";

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAvailableLanguage>? AvailableLanguage { get; set; } //Language, string

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [DataMember(Name = "contactOption", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPointOption>? ContactOption { get; set; } 

        /// <summary>
        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        [DataMember(Name = "contactType", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ContactType { get; set; } 

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Email { get; set; } 

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FaxNumber { get; set; } 

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OpeningHoursSpecification>? HoursAvailable { get; set; } 

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [DataMember(Name = "productSupported", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProductSupported>? ProductSupported { get; set; } //Product, string

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; } 
    }
}
