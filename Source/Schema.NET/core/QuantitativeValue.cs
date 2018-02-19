using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    [DataContract]
    public partial class QuantitativeValue : StructuredValue
    {
        public interface IUnitCode : IWrapper { }
        public interface IUnitCode<T> : IUnitCode { new T Data { get; set; } }
        public class UnitCodestring : IUnitCode<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public UnitCodestring () { }
            public UnitCodestring (string data) { Data = data; }
            public static implicit operator UnitCodestring (string data) { return new UnitCodestring (data); }
        }

        public class UnitCodeUri : IUnitCode<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public UnitCodeUri () { }
            public UnitCodeUri (Uri data) { Data = data; }
            public static implicit operator UnitCodeUri (Uri data) { return new UnitCodeUri (data); }
        }


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


        public interface IValueReference : IWrapper { }
        public interface IValueReference<T> : IValueReference { new T Data { get; set; } }
        public class ValueReferencePropertyValue : IValueReference<PropertyValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PropertyValue) value; } }
            public virtual PropertyValue Data { get; set; }
            public ValueReferencePropertyValue () { }
            public ValueReferencePropertyValue (PropertyValue data) { Data = data; }
            public static implicit operator ValueReferencePropertyValue (PropertyValue data) { return new ValueReferencePropertyValue (data); }
        }

        public class ValueReferenceQuantitativeValue : IValueReference<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public ValueReferenceQuantitativeValue () { }
            public ValueReferenceQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator ValueReferenceQuantitativeValue (QuantitativeValue data) { return new ValueReferenceQuantitativeValue (data); }
        }

        public class ValueReferenceStructuredValue : IValueReference<StructuredValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (StructuredValue) value; } }
            public virtual StructuredValue Data { get; set; }
            public ValueReferenceStructuredValue () { }
            public ValueReferenceStructuredValue (StructuredValue data) { Data = data; }
            public static implicit operator ValueReferenceStructuredValue (StructuredValue data) { return new ValueReferenceStructuredValue (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeValue";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PropertyValue>? AdditionalProperty { get; set; } 

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
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IUnitCode>? UnitCode { get; set; } //string, Uri

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UnitText { get; set; } 

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

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IValueReference>? ValueReference { get; set; } //PropertyValue, QuantitativeValue, StructuredValue
    }
}
