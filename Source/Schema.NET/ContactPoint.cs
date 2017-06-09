namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    [DataContract]
    public class ContactPoint : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPoint";

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 2)]
        public object AreaServed { get; protected set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public AdministrativeArea AreaServedAdministrativeArea
        {
            get => this.AreaServed as AdministrativeArea;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape AreaServedGeoShape
        {
            get => this.AreaServed as GeoShape;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public Place AreaServedPlace
        {
            get => this.AreaServed as Place;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public string AreaServedText
        {
            get => this.AreaServed as string;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 3)]
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
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [DataMember(Name = "contactOption", Order = 4)]
        public ContactPointOption ContactOption { get; set; }

        /// <summary>
        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        [DataMember(Name = "contactType", Order = 5)]
        public string ContactType { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 6)]
        public string Email { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 7)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 8)]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [DataMember(Name = "productSupported", Order = 9)]
        public object ProductSupported { get; protected set; }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [IgnoreDataMember]
        public Product ProductSupportedProduct
        {
            get => this.ProductSupported as Product;
            set => this.ProductSupported = value;
        }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [IgnoreDataMember]
        public string ProductSupportedText
        {
            get => this.ProductSupported as string;
            set => this.ProductSupported = value;
        }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 10)]
        public string Telephone { get; set; }
    }
}
