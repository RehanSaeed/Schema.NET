namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    [DataContract]
    public partial class GeoCoordinates : StructuredValue
    {
        public interface IAddress : IValue {}
        public interface IAddress<T> : IAddress { new T Value { get; } }
        public class OneOrManyAddress : OneOrMany<IAddress>
        {
            public OneOrManyAddress(IAddress item) : base(item) { }
            public OneOrManyAddress(IEnumerable<IAddress> items) : base(items) { }
            public static implicit operator OneOrManyAddress (PostalAddress value) { return new OneOrManyAddress (new AddressPostalAddress (value)); }
            public static implicit operator OneOrManyAddress (PostalAddress[] values) { return new OneOrManyAddress (values.Select(v => (IAddress) new AddressPostalAddress (v))); }
            public static implicit operator OneOrManyAddress (List<PostalAddress> values) { return new OneOrManyAddress (values.Select(v => (IAddress) new AddressPostalAddress (v))); }
            public static implicit operator OneOrManyAddress (string value) { return new OneOrManyAddress (new Addressstring (value)); }
            public static implicit operator OneOrManyAddress (string[] values) { return new OneOrManyAddress (values.Select(v => (IAddress) new Addressstring (v))); }
            public static implicit operator OneOrManyAddress (List<string> values) { return new OneOrManyAddress (values.Select(v => (IAddress) new Addressstring (v))); }
        }
        public struct AddressPostalAddress : IAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public AddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator AddressPostalAddress (PostalAddress value) { return new AddressPostalAddress (value); }
        }
        public struct Addressstring : IAddress<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Addressstring (string value) { Value = value; }
            public static implicit operator Addressstring (string value) { return new Addressstring (value); }
        }

        public interface IAddressCountry : IValue {}
        public interface IAddressCountry<T> : IAddressCountry { new T Value { get; } }
        public class OneOrManyAddressCountry : OneOrMany<IAddressCountry>
        {
            public OneOrManyAddressCountry(IAddressCountry item) : base(item) { }
            public OneOrManyAddressCountry(IEnumerable<IAddressCountry> items) : base(items) { }
            public static implicit operator OneOrManyAddressCountry (Country value) { return new OneOrManyAddressCountry (new AddressCountryCountry (value)); }
            public static implicit operator OneOrManyAddressCountry (Country[] values) { return new OneOrManyAddressCountry (values.Select(v => (IAddressCountry) new AddressCountryCountry (v))); }
            public static implicit operator OneOrManyAddressCountry (List<Country> values) { return new OneOrManyAddressCountry (values.Select(v => (IAddressCountry) new AddressCountryCountry (v))); }
            public static implicit operator OneOrManyAddressCountry (string value) { return new OneOrManyAddressCountry (new AddressCountrystring (value)); }
            public static implicit operator OneOrManyAddressCountry (string[] values) { return new OneOrManyAddressCountry (values.Select(v => (IAddressCountry) new AddressCountrystring (v))); }
            public static implicit operator OneOrManyAddressCountry (List<string> values) { return new OneOrManyAddressCountry (values.Select(v => (IAddressCountry) new AddressCountrystring (v))); }
        }
        public struct AddressCountryCountry : IAddressCountry<Country>
        {
            object IValue.Value => this.Value;
            public Country Value { get; }
            public AddressCountryCountry (Country value) { Value = value; }
            public static implicit operator AddressCountryCountry (Country value) { return new AddressCountryCountry (value); }
        }
        public struct AddressCountrystring : IAddressCountry<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AddressCountrystring (string value) { Value = value; }
            public static implicit operator AddressCountrystring (string value) { return new AddressCountrystring (value); }
        }

        public interface IElevation : IValue {}
        public interface IElevation<T> : IElevation { new T Value { get; } }
        public class OneOrManyElevation : OneOrMany<IElevation>
        {
            public OneOrManyElevation(IElevation item) : base(item) { }
            public OneOrManyElevation(IEnumerable<IElevation> items) : base(items) { }
            public static implicit operator OneOrManyElevation (double value) { return new OneOrManyElevation (new Elevationdouble (value)); }
            public static implicit operator OneOrManyElevation (double[] values) { return new OneOrManyElevation (values.Select(v => (IElevation) new Elevationdouble (v))); }
            public static implicit operator OneOrManyElevation (List<double> values) { return new OneOrManyElevation (values.Select(v => (IElevation) new Elevationdouble (v))); }
            public static implicit operator OneOrManyElevation (string value) { return new OneOrManyElevation (new Elevationstring (value)); }
            public static implicit operator OneOrManyElevation (string[] values) { return new OneOrManyElevation (values.Select(v => (IElevation) new Elevationstring (v))); }
            public static implicit operator OneOrManyElevation (List<string> values) { return new OneOrManyElevation (values.Select(v => (IElevation) new Elevationstring (v))); }
        }
        public struct Elevationdouble : IElevation<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public Elevationdouble (double value) { Value = value; }
            public static implicit operator Elevationdouble (double value) { return new Elevationdouble (value); }
        }
        public struct Elevationstring : IElevation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Elevationstring (string value) { Value = value; }
            public static implicit operator Elevationstring (string value) { return new Elevationstring (value); }
        }

        public interface ILatitude : IValue {}
        public interface ILatitude<T> : ILatitude { new T Value { get; } }
        public class OneOrManyLatitude : OneOrMany<ILatitude>
        {
            public OneOrManyLatitude(ILatitude item) : base(item) { }
            public OneOrManyLatitude(IEnumerable<ILatitude> items) : base(items) { }
            public static implicit operator OneOrManyLatitude (double value) { return new OneOrManyLatitude (new Latitudedouble (value)); }
            public static implicit operator OneOrManyLatitude (double[] values) { return new OneOrManyLatitude (values.Select(v => (ILatitude) new Latitudedouble (v))); }
            public static implicit operator OneOrManyLatitude (List<double> values) { return new OneOrManyLatitude (values.Select(v => (ILatitude) new Latitudedouble (v))); }
            public static implicit operator OneOrManyLatitude (string value) { return new OneOrManyLatitude (new Latitudestring (value)); }
            public static implicit operator OneOrManyLatitude (string[] values) { return new OneOrManyLatitude (values.Select(v => (ILatitude) new Latitudestring (v))); }
            public static implicit operator OneOrManyLatitude (List<string> values) { return new OneOrManyLatitude (values.Select(v => (ILatitude) new Latitudestring (v))); }
        }
        public struct Latitudedouble : ILatitude<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public Latitudedouble (double value) { Value = value; }
            public static implicit operator Latitudedouble (double value) { return new Latitudedouble (value); }
        }
        public struct Latitudestring : ILatitude<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Latitudestring (string value) { Value = value; }
            public static implicit operator Latitudestring (string value) { return new Latitudestring (value); }
        }

        public interface ILongitude : IValue {}
        public interface ILongitude<T> : ILongitude { new T Value { get; } }
        public class OneOrManyLongitude : OneOrMany<ILongitude>
        {
            public OneOrManyLongitude(ILongitude item) : base(item) { }
            public OneOrManyLongitude(IEnumerable<ILongitude> items) : base(items) { }
            public static implicit operator OneOrManyLongitude (double value) { return new OneOrManyLongitude (new Longitudedouble (value)); }
            public static implicit operator OneOrManyLongitude (double[] values) { return new OneOrManyLongitude (values.Select(v => (ILongitude) new Longitudedouble (v))); }
            public static implicit operator OneOrManyLongitude (List<double> values) { return new OneOrManyLongitude (values.Select(v => (ILongitude) new Longitudedouble (v))); }
            public static implicit operator OneOrManyLongitude (string value) { return new OneOrManyLongitude (new Longitudestring (value)); }
            public static implicit operator OneOrManyLongitude (string[] values) { return new OneOrManyLongitude (values.Select(v => (ILongitude) new Longitudestring (v))); }
            public static implicit operator OneOrManyLongitude (List<string> values) { return new OneOrManyLongitude (values.Select(v => (ILongitude) new Longitudestring (v))); }
        }
        public struct Longitudedouble : ILongitude<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public Longitudedouble (double value) { Value = value; }
            public static implicit operator Longitudedouble (double value) { return new Longitudedouble (value); }
        }
        public struct Longitudestring : ILongitude<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Longitudestring (string value) { Value = value; }
            public static implicit operator Longitudestring (string value) { return new Longitudestring (value); }
        }

        public interface IPostalCode : IValue {}
        public interface IPostalCode<T> : IPostalCode { new T Value { get; } }
        public class OneOrManyPostalCode : OneOrMany<IPostalCode>
        {
            public OneOrManyPostalCode(IPostalCode item) : base(item) { }
            public OneOrManyPostalCode(IEnumerable<IPostalCode> items) : base(items) { }
            public static implicit operator OneOrManyPostalCode (string value) { return new OneOrManyPostalCode (new PostalCodestring (value)); }
            public static implicit operator OneOrManyPostalCode (string[] values) { return new OneOrManyPostalCode (values.Select(v => (IPostalCode) new PostalCodestring (v))); }
            public static implicit operator OneOrManyPostalCode (List<string> values) { return new OneOrManyPostalCode (values.Select(v => (IPostalCode) new PostalCodestring (v))); }
        }
        public struct PostalCodestring : IPostalCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PostalCodestring (string value) { Value = value; }
            public static implicit operator PostalCodestring (string value) { return new PostalCodestring (value); }
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
        public OneOrManyAddress Address { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 307)]
        public OneOrManyAddressCountry AddressCountry { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "elevation", Order = 308)]
        public OneOrManyElevation Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude", Order = 309)]
        public OneOrManyLatitude Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude", Order = 310)]
        public OneOrManyLongitude Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 311)]
        public OneOrManyPostalCode PostalCode { get; set; }
    }
}
