namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
    [DataContract]
    public partial class GeoShape : StructuredValue
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

        public interface IBox : IValue {}
        public interface IBox<T> : IBox { new T Value { get; } }
        public class OneOrManyBox : OneOrMany<IBox>
        {
            public OneOrManyBox(IBox item) : base(item) { }
            public OneOrManyBox(IEnumerable<IBox> items) : base(items) { }
            public static implicit operator OneOrManyBox (string value) { return new OneOrManyBox (new Boxstring (value)); }
            public static implicit operator OneOrManyBox (string[] values) { return new OneOrManyBox (values.Select(v => (IBox) new Boxstring (v))); }
            public static implicit operator OneOrManyBox (List<string> values) { return new OneOrManyBox (values.Select(v => (IBox) new Boxstring (v))); }
        }
        public struct Boxstring : IBox<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Boxstring (string value) { Value = value; }
            public static implicit operator Boxstring (string value) { return new Boxstring (value); }
        }

        public interface ICircle : IValue {}
        public interface ICircle<T> : ICircle { new T Value { get; } }
        public class OneOrManyCircle : OneOrMany<ICircle>
        {
            public OneOrManyCircle(ICircle item) : base(item) { }
            public OneOrManyCircle(IEnumerable<ICircle> items) : base(items) { }
            public static implicit operator OneOrManyCircle (string value) { return new OneOrManyCircle (new Circlestring (value)); }
            public static implicit operator OneOrManyCircle (string[] values) { return new OneOrManyCircle (values.Select(v => (ICircle) new Circlestring (v))); }
            public static implicit operator OneOrManyCircle (List<string> values) { return new OneOrManyCircle (values.Select(v => (ICircle) new Circlestring (v))); }
        }
        public struct Circlestring : ICircle<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Circlestring (string value) { Value = value; }
            public static implicit operator Circlestring (string value) { return new Circlestring (value); }
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

        public interface ILine : IValue {}
        public interface ILine<T> : ILine { new T Value { get; } }
        public class OneOrManyLine : OneOrMany<ILine>
        {
            public OneOrManyLine(ILine item) : base(item) { }
            public OneOrManyLine(IEnumerable<ILine> items) : base(items) { }
            public static implicit operator OneOrManyLine (string value) { return new OneOrManyLine (new Linestring (value)); }
            public static implicit operator OneOrManyLine (string[] values) { return new OneOrManyLine (values.Select(v => (ILine) new Linestring (v))); }
            public static implicit operator OneOrManyLine (List<string> values) { return new OneOrManyLine (values.Select(v => (ILine) new Linestring (v))); }
        }
        public struct Linestring : ILine<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Linestring (string value) { Value = value; }
            public static implicit operator Linestring (string value) { return new Linestring (value); }
        }

        public interface IPolygon : IValue {}
        public interface IPolygon<T> : IPolygon { new T Value { get; } }
        public class OneOrManyPolygon : OneOrMany<IPolygon>
        {
            public OneOrManyPolygon(IPolygon item) : base(item) { }
            public OneOrManyPolygon(IEnumerable<IPolygon> items) : base(items) { }
            public static implicit operator OneOrManyPolygon (string value) { return new OneOrManyPolygon (new Polygonstring (value)); }
            public static implicit operator OneOrManyPolygon (string[] values) { return new OneOrManyPolygon (values.Select(v => (IPolygon) new Polygonstring (v))); }
            public static implicit operator OneOrManyPolygon (List<string> values) { return new OneOrManyPolygon (values.Select(v => (IPolygon) new Polygonstring (v))); }
        }
        public struct Polygonstring : IPolygon<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Polygonstring (string value) { Value = value; }
            public static implicit operator Polygonstring (string value) { return new Polygonstring (value); }
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
        public override string Type => "GeoShape";

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
        /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
        /// </summary>
        [DataMember(Name = "box", Order = 308)]
        public OneOrManyBox Box { get; set; }

        /// <summary>
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        [DataMember(Name = "circle", Order = 309)]
        public OneOrManyCircle Circle { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "elevation", Order = 310)]
        public OneOrManyElevation Elevation { get; set; }

        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        [DataMember(Name = "line", Order = 311)]
        public OneOrManyLine Line { get; set; }

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        [DataMember(Name = "polygon", Order = 312)]
        public OneOrManyPolygon Polygon { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 313)]
        public OneOrManyPostalCode PostalCode { get; set; }
    }
}
