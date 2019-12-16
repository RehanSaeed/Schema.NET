namespace Schema.NET
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
    public partial class PostalAddress : ContactPoint, IPostalAddress, IEquatable<PostalAddress>
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

        /// <inheritdoc/>
        public bool Equals(PostalAddress other)
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
                this.AddressCountry == other.AddressCountry &&
                this.AddressLocality == other.AddressLocality &&
                this.AddressRegion == other.AddressRegion &&
                this.PostalCode == other.PostalCode &&
                this.PostOfficeBoxNumber == other.PostOfficeBoxNumber &&
                this.StreetAddress == other.StreetAddress &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PostalAddress);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AddressCountry)
            .And(this.AddressLocality)
            .And(this.AddressRegion)
            .And(this.PostalCode)
            .And(this.PostOfficeBoxNumber)
            .And(this.StreetAddress)
            .And(base.GetHashCode());
    }
}
