namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place...
    /// </summary>
    [DataContract]
    public partial class PropertyValue : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValue";

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?>? MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?>? MinValue { get; set; }

        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        [DataMember(Name = "propertyID", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? PropertyID { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UnitText { get; set; }

        /// <summary>
        /// &lt;p&gt;The value of the quantitative value or property value node.&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<StructuredValue, bool?, string, double?>? Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue, StructuredValue, PropertyValue>? ValueReference { get; set; }
    }
}
