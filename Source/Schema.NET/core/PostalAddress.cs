namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract]
    public partial class PostalAddress : ContactPoint
    {
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

        public interface IAddressLocality : IValue {}
        public interface IAddressLocality<T> : IAddressLocality { new T Value { get; } }
        public class OneOrManyAddressLocality : OneOrMany<IAddressLocality>
        {
            public OneOrManyAddressLocality(IAddressLocality item) : base(item) { }
            public OneOrManyAddressLocality(IEnumerable<IAddressLocality> items) : base(items) { }
            public static implicit operator OneOrManyAddressLocality (string value) { return new OneOrManyAddressLocality (new AddressLocalitystring (value)); }
            public static implicit operator OneOrManyAddressLocality (string[] values) { return new OneOrManyAddressLocality (values.Select(v => (IAddressLocality) new AddressLocalitystring (v))); }
            public static implicit operator OneOrManyAddressLocality (List<string> values) { return new OneOrManyAddressLocality (values.Select(v => (IAddressLocality) new AddressLocalitystring (v))); }
        }
        public struct AddressLocalitystring : IAddressLocality<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AddressLocalitystring (string value) { Value = value; }
            public static implicit operator AddressLocalitystring (string value) { return new AddressLocalitystring (value); }
        }

        public interface IAddressRegion : IValue {}
        public interface IAddressRegion<T> : IAddressRegion { new T Value { get; } }
        public class OneOrManyAddressRegion : OneOrMany<IAddressRegion>
        {
            public OneOrManyAddressRegion(IAddressRegion item) : base(item) { }
            public OneOrManyAddressRegion(IEnumerable<IAddressRegion> items) : base(items) { }
            public static implicit operator OneOrManyAddressRegion (string value) { return new OneOrManyAddressRegion (new AddressRegionstring (value)); }
            public static implicit operator OneOrManyAddressRegion (string[] values) { return new OneOrManyAddressRegion (values.Select(v => (IAddressRegion) new AddressRegionstring (v))); }
            public static implicit operator OneOrManyAddressRegion (List<string> values) { return new OneOrManyAddressRegion (values.Select(v => (IAddressRegion) new AddressRegionstring (v))); }
        }
        public struct AddressRegionstring : IAddressRegion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AddressRegionstring (string value) { Value = value; }
            public static implicit operator AddressRegionstring (string value) { return new AddressRegionstring (value); }
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

        public interface IPostOfficeBoxNumber : IValue {}
        public interface IPostOfficeBoxNumber<T> : IPostOfficeBoxNumber { new T Value { get; } }
        public class OneOrManyPostOfficeBoxNumber : OneOrMany<IPostOfficeBoxNumber>
        {
            public OneOrManyPostOfficeBoxNumber(IPostOfficeBoxNumber item) : base(item) { }
            public OneOrManyPostOfficeBoxNumber(IEnumerable<IPostOfficeBoxNumber> items) : base(items) { }
            public static implicit operator OneOrManyPostOfficeBoxNumber (string value) { return new OneOrManyPostOfficeBoxNumber (new PostOfficeBoxNumberstring (value)); }
            public static implicit operator OneOrManyPostOfficeBoxNumber (string[] values) { return new OneOrManyPostOfficeBoxNumber (values.Select(v => (IPostOfficeBoxNumber) new PostOfficeBoxNumberstring (v))); }
            public static implicit operator OneOrManyPostOfficeBoxNumber (List<string> values) { return new OneOrManyPostOfficeBoxNumber (values.Select(v => (IPostOfficeBoxNumber) new PostOfficeBoxNumberstring (v))); }
        }
        public struct PostOfficeBoxNumberstring : IPostOfficeBoxNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PostOfficeBoxNumberstring (string value) { Value = value; }
            public static implicit operator PostOfficeBoxNumberstring (string value) { return new PostOfficeBoxNumberstring (value); }
        }

        public interface IStreetAddress : IValue {}
        public interface IStreetAddress<T> : IStreetAddress { new T Value { get; } }
        public class OneOrManyStreetAddress : OneOrMany<IStreetAddress>
        {
            public OneOrManyStreetAddress(IStreetAddress item) : base(item) { }
            public OneOrManyStreetAddress(IEnumerable<IStreetAddress> items) : base(items) { }
            public static implicit operator OneOrManyStreetAddress (string value) { return new OneOrManyStreetAddress (new StreetAddressstring (value)); }
            public static implicit operator OneOrManyStreetAddress (string[] values) { return new OneOrManyStreetAddress (values.Select(v => (IStreetAddress) new StreetAddressstring (v))); }
            public static implicit operator OneOrManyStreetAddress (List<string> values) { return new OneOrManyStreetAddress (values.Select(v => (IStreetAddress) new StreetAddressstring (v))); }
        }
        public struct StreetAddressstring : IStreetAddress<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public StreetAddressstring (string value) { Value = value; }
            public static implicit operator StreetAddressstring (string value) { return new StreetAddressstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 406)]
        public OneOrManyAddressCountry AddressCountry { get; set; }

        /// <summary>
        /// The locality. For example, Mountain View.
        /// </summary>
        [DataMember(Name = "addressLocality", Order = 407)]
        public OneOrManyAddressLocality AddressLocality { get; set; }

        /// <summary>
        /// The region. For example, CA.
        /// </summary>
        [DataMember(Name = "addressRegion", Order = 408)]
        public OneOrManyAddressRegion AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 409)]
        public OneOrManyPostalCode PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [DataMember(Name = "postOfficeBoxNumber", Order = 410)]
        public OneOrManyPostOfficeBoxNumber PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [DataMember(Name = "streetAddress", Order = 411)]
        public OneOrManyStreetAddress StreetAddress { get; set; }
    }
}
