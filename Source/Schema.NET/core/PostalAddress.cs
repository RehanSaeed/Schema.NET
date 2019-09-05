﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The mailing address.
    /// </summary>
    public partial interface IPostalAddress : IContactPoint
    {
        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The locality in which the street address is, and which is in the region. For example, Mountain View.
        /// </summary>
        OneOrMany<string> AddressLocality { get; set; }

        /// <summary>
        /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
        /// </summary>
        OneOrMany<string> AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        OneOrMany<string> PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        OneOrMany<string> PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        OneOrMany<string> StreetAddress { get; set; }
    }

    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract]
    public partial class PostalAddress : ContactPoint, IPostalAddress
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The locality in which the street address is, and which is in the region. For example, Mountain View.
        /// </summary>
        [DataMember(Name = "addressLocality", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AddressLocality { get; set; }

        /// <summary>
        /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "addressRegion", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [DataMember(Name = "postOfficeBoxNumber", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [DataMember(Name = "streetAddress", Order = 411)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StreetAddress { get; set; }
    }
}
