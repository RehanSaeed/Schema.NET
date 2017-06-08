namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract]
    public class PostalAddress : ContactPoint
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [DataMember(Name = "postOfficeBoxNumber")]
        public string PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry")]
        public object AddressCountry { get; protected set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Country AddressCountryCountry
        {
            get => this.AddressCountry as Country;
            set => this.AddressCountry = value;
        }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string AddressCountryText
        {
            get => this.AddressCountry as string;
            set => this.AddressCountry = value;
        }

        /// <summary>
        /// The region. For example, CA.
        /// </summary>
        [DataMember(Name = "addressRegion")]
        public string AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The locality. For example, Mountain View.
        /// </summary>
        [DataMember(Name = "addressLocality")]
        public string AddressLocality { get; set; }
    }
}
