namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// </summary>
    public partial interface IPropertyValue : IStructuredValue
    {
        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        Values<string, Uri> MeasurementTechnique { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        Values<string, Uri> PropertyID { get; set; }

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
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// </summary>
    [DataContract]
    public partial class PropertyValue : StructuredValue, IPropertyValue, IEquatable<PropertyValue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValue";

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> MeasurementTechnique { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        [DataMember(Name = "propertyID", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> PropertyID { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 311)]
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
        [DataMember(Name = "value", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, double?, IStructuredValue, string> Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, IQuantitativeValue, IStructuredValue> ValueReference { get; set; }

        /// <inheritdoc/>
        public bool Equals(PropertyValue other)
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
                this.MaxValue == other.MaxValue &&
                this.MeasurementTechnique == other.MeasurementTechnique &&
                this.MinValue == other.MinValue &&
                this.PropertyID == other.PropertyID &&
                this.UnitCode == other.UnitCode &&
                this.UnitText == other.UnitText &&
                this.Value == other.Value &&
                this.ValueReference == other.ValueReference &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PropertyValue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.MaxValue)
            .And(this.MeasurementTechnique)
            .And(this.MinValue)
            .And(this.PropertyID)
            .And(this.UnitCode)
            .And(this.UnitText)
            .And(this.Value)
            .And(this.ValueReference)
            .And(base.GetHashCode());
    }
}
