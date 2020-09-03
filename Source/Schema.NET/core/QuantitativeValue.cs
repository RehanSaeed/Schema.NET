namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    public partial interface IQuantitativeValue : IStructuredValue
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        Values<string, Uri> UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<bool?, double?, IStructuredValue, string> Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        Values<IPropertyValue, IQuantitativeValue, IStructuredValue> ValueReference { get; set; }
    }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    [DataContract]
    public partial class QuantitativeValue : StructuredValue, IQuantitativeValue, IEquatable<QuantitativeValue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeValue";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, double?, IStructuredValue, string> Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, IQuantitativeValue, IStructuredValue> ValueReference { get; set; }

        /// <inheritdoc/>
        public bool Equals(QuantitativeValue other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.AdditionalProperty == other.AdditionalProperty &&
                this.MaxValue == other.MaxValue &&
                this.MinValue == other.MinValue &&
                this.UnitCode == other.UnitCode &&
                this.UnitText == other.UnitText &&
                this.Value == other.Value &&
                this.ValueReference == other.ValueReference &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as QuantitativeValue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AdditionalProperty)
            .And(this.MaxValue)
            .And(this.MinValue)
            .And(this.UnitCode)
            .And(this.UnitText)
            .And(this.Value)
            .And(this.ValueReference)
            .And(base.GetHashCode());
    }
}
