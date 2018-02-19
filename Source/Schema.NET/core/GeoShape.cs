using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
    [DataContract]
    public partial class GeoShape : StructuredValue
    {
        public interface IAddress : IWrapper { }
        public interface IAddress<T> : IAddress { new T Data { get; set; } }
        public class AddressPostalAddress : IAddress<PostalAddress>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PostalAddress) value; } }
            public virtual PostalAddress Data { get; set; }
            public AddressPostalAddress () { }
            public AddressPostalAddress (PostalAddress data) { Data = data; }
            public static implicit operator AddressPostalAddress (PostalAddress data) { return new AddressPostalAddress (data); }
        }

        public class Addressstring : IAddress<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Addressstring () { }
            public Addressstring (string data) { Data = data; }
            public static implicit operator Addressstring (string data) { return new Addressstring (data); }
        }


        public interface IAddressCountry : IWrapper { }
        public interface IAddressCountry<T> : IAddressCountry { new T Data { get; set; } }
        public class AddressCountryCountry : IAddressCountry<Country>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Country) value; } }
            public virtual Country Data { get; set; }
            public AddressCountryCountry () { }
            public AddressCountryCountry (Country data) { Data = data; }
            public static implicit operator AddressCountryCountry (Country data) { return new AddressCountryCountry (data); }
        }

        public class AddressCountrystring : IAddressCountry<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AddressCountrystring () { }
            public AddressCountrystring (string data) { Data = data; }
            public static implicit operator AddressCountrystring (string data) { return new AddressCountrystring (data); }
        }


        public interface IElevation : IWrapper { }
        public interface IElevation<T> : IElevation { new T Data { get; set; } }
        public class Elevationdouble : IElevation<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public Elevationdouble () { }
            public Elevationdouble (double data) { Data = data; }
            public static implicit operator Elevationdouble (double data) { return new Elevationdouble (data); }
        }

        public class Elevationstring : IElevation<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Elevationstring () { }
            public Elevationstring (string data) { Data = data; }
            public static implicit operator Elevationstring (string data) { return new Elevationstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoShape";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAddress>? Address { get; set; } //PostalAddress, string

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAddressCountry>? AddressCountry { get; set; } //Country, string

        /// <summary>
        /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
        /// </summary>
        [DataMember(Name = "box", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Box { get; set; } 

        /// <summary>
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        [DataMember(Name = "circle", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Circle { get; set; } 

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "elevation", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IElevation>? Elevation { get; set; } //double?, string

        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        [DataMember(Name = "line", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Line { get; set; } 

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        [DataMember(Name = "polygon", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Polygon { get; set; } 

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostalCode { get; set; } 
    }
}
