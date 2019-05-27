﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
    public partial interface IGeoShape : IStructuredValue
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
        /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
        /// </summary>
        OneOrMany<string> Box { get; set; }

        /// <summary>
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        OneOrMany<string> Circle { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        OneOrMany<string> Line { get; set; }

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        OneOrMany<string> Polygon { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        OneOrMany<string> PostalCode { get; set; }
    }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
    [DataContract]
    public partial class GeoShape : StructuredValue, IGeoShape
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoShape";

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
        /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
        /// </summary>
        [DataMember(Name = "box", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Box { get; set; }

        /// <summary>
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        [DataMember(Name = "circle", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Circle { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        [DataMember(Name = "elevation", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        [DataMember(Name = "line", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Line { get; set; }

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        [DataMember(Name = "polygon", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Polygon { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostalCode { get; set; }
    }
}
