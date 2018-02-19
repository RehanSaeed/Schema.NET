using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    [DataContract]
    public partial class GeoCoordinates : StructuredValue
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


        public interface ILatitude : IWrapper { }
        public interface ILatitude<T> : ILatitude { new T Data { get; set; } }
        public class Latitudedouble : ILatitude<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public Latitudedouble () { }
            public Latitudedouble (double data) { Data = data; }
            public static implicit operator Latitudedouble (double data) { return new Latitudedouble (data); }
        }

        public class Latitudestring : ILatitude<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Latitudestring () { }
            public Latitudestring (string data) { Data = data; }
            public static implicit operator Latitudestring (string data) { return new Latitudestring (data); }
        }


        public interface ILongitude : IWrapper { }
        public interface ILongitude<T> : ILongitude { new T Data { get; set; } }
        public class Longitudedouble : ILongitude<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public Longitudedouble () { }
            public Longitudedouble (double data) { Data = data; }
            public static implicit operator Longitudedouble (double data) { return new Longitudedouble (data); }
        }

        public class Longitudestring : ILongitude<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Longitudestring () { }
            public Longitudestring (string data) { Data = data; }
            public static implicit operator Longitudestring (string data) { return new Longitudestring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoCoordinates";

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
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "elevation", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IElevation>? Elevation { get; set; } //double?, string

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILatitude>? Latitude { get; set; } //double?, string

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILongitude>? Longitude { get; set; } //double?, string

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostalCode { get; set; } 
    }
}
