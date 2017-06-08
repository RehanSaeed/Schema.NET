namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    [DataContract]
    public class GeoCoordinates : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GeoCoordinates";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address")]
        public object Address { get; protected set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress AddressPostalAddress
        {
            get => this.Address as PostalAddress;
            set => this.Address = value;
        }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public string AddressText
        {
            get => this.Address as string;
            set => this.Address = value;
        }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude")]
        public object Latitude { get; protected set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public string LatitudeText
        {
            get => this.Latitude as string;
            set => this.Latitude = value;
        }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public decimal? LatitudeNumber
        {
            get => this.Latitude as decimal?;
            set => this.Latitude = value;
        }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude")]
        public object Longitude { get; protected set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public decimal? LongitudeNumber
        {
            get => this.Longitude as decimal?;
            set => this.Longitude = value;
        }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public string LongitudeText
        {
            get => this.Longitude as string;
            set => this.Longitude = value;
        }

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
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "elevation")]
        public object Elevation { get; protected set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public decimal? ElevationNumber
        {
            get => this.Elevation as decimal?;
            set => this.Elevation = value;
        }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [IgnoreDataMember]
        public string ElevationText
        {
            get => this.Elevation as string;
            set => this.Elevation = value;
        }
    }
}
