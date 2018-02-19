using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.
    /// </summary>
    [DataContract]
    public partial class MonetaryAmount : StructuredValue
    {
        public interface IValue : IWrapper { }
        public interface IValue<T> : IValue { new T Data { get; set; } }
        public class Valuebool : IValue<bool>
        {
            object IWrapper.Data { get { return Data; } set { Data = (bool) value; } }
            public virtual bool Data { get; set; }
            public Valuebool () { }
            public Valuebool (bool data) { Data = data; }
            public static implicit operator Valuebool (bool data) { return new Valuebool (data); }
        }

        public class Valuedouble : IValue<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public Valuedouble () { }
            public Valuedouble (double data) { Data = data; }
            public static implicit operator Valuedouble (double data) { return new Valuedouble (data); }
        }

        public class ValueStructuredValue : IValue<StructuredValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (StructuredValue) value; } }
            public virtual StructuredValue Data { get; set; }
            public ValueStructuredValue () { }
            public ValueStructuredValue (StructuredValue data) { Data = data; }
            public static implicit operator ValueStructuredValue (StructuredValue data) { return new ValueStructuredValue (data); }
        }

        public class Valuestring : IValue<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Valuestring () { }
            public Valuestring (string data) { Data = data; }
            public static implicit operator Valuestring (string data) { return new Valuestring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmount";

        /// <summary>
        /// The currency in which the monetary amount is expressed (in 3-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; format).
        /// </summary>
        [DataMember(Name = "currency", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Currency { get; set; } 

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? MaxValue { get; set; } 

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? MinValue { get; set; } 

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ValidFrom { get; set; } 

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ValidThrough { get; set; } 

        /// <summary>
        /// &lt;p&gt;The value of the quantitative value or property value node.&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IValue>? Value { get; set; } //bool?, double?, StructuredValue, string
    }
}
