﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public partial interface IGeoCoordinates : IStructuredValue
    {
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        OneOrMany<string> PostalCode { get; set; }
    }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    [DataContract]
    public partial class GeoCoordinates : StructuredValue, IGeoCoordinates, IEquatable<GeoCoordinates>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoCoordinates";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        [DataMember(Name = "elevation", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostalCode { get; set; }

        /// <inheritdoc/>
        public bool Equals(GeoCoordinates other)
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
                this.Address == other.Address &&
                this.AddressCountry == other.AddressCountry &&
                this.Elevation == other.Elevation &&
                this.Latitude == other.Latitude &&
                this.Longitude == other.Longitude &&
                this.PostalCode == other.PostalCode &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as GeoCoordinates);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Address)
            .And(this.AddressCountry)
            .And(this.Elevation)
            .And(this.Latitude)
            .And(this.Longitude)
            .And(this.PostalCode)
            .And(base.GetHashCode());
    }
}
