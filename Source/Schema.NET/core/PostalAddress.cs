namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract]
    public partial class PostalAddress : ContactPoint
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country, string>? AddressCountry { get; set; }

        /// <summary>
        /// The locality. For example, Mountain View.
        /// </summary>
        [DataMember(Name = "addressLocality", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AddressLocality { get; set; }

        /// <summary>
        /// The region. For example, CA.
        /// </summary>
        [DataMember(Name = "addressRegion", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [DataMember(Name = "postOfficeBoxNumber", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [DataMember(Name = "streetAddress", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? StreetAddress { get; set; }
    }
}
