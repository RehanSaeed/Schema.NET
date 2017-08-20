namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    [DataContract]
    public partial class ContactPoint : StructuredValue
    {
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
        public Values<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Language, string>? AvailableLanguage { get; set; }

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [DataMember(Name = "contactOption", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPointOption?>? ContactOption { get; set; }

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
        public Values<Product, string>? ProductSupported { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; }
    }
}
