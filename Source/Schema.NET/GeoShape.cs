namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs...
    /// </summary>
    [DataContract]
    public class GeoShape : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GeoShape";

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
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        [DataMember(Name = "circle")]
        public string Circle { get; set; }

        /// <summary>
        /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
        /// </summary>
        [DataMember(Name = "box")]
        public string Box { get; set; }

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

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        [DataMember(Name = "polygon")]
        public string Polygon { get; set; }

        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        [DataMember(Name = "line")]
        public string Line { get; set; }
    }
}
