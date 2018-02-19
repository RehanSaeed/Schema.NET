using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract]
    public partial class PostalAddress : ContactPoint
    {
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "addressCountry", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAddressCountry>? AddressCountry { get; set; } //Country, string

        /// <summary>
        /// The locality. For example, Mountain View.
        /// </summary>
        [DataMember(Name = "addressLocality", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AddressLocality { get; set; } 

        /// <summary>
        /// The region. For example, CA.
        /// </summary>
        [DataMember(Name = "addressRegion", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AddressRegion { get; set; } 

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [DataMember(Name = "postalCode", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostalCode { get; set; } 

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [DataMember(Name = "postOfficeBoxNumber", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PostOfficeBoxNumber { get; set; } 

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [DataMember(Name = "streetAddress", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? StreetAddress { get; set; } 
    }
}
