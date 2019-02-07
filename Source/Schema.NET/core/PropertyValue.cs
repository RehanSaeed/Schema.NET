namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// </summary>
    [DataContract]
    public partial class PropertyValue : StructuredValue
    {
        public interface IMaxValue : IValue {}
        public interface IMaxValue<T> : IMaxValue { new T Value { get; } }
        public class OneOrManyMaxValue : OneOrMany<IMaxValue>
        {
            public OneOrManyMaxValue(IMaxValue item) : base(item) { }
            public OneOrManyMaxValue(IEnumerable<IMaxValue> items) : base(items) { }
            public static implicit operator OneOrManyMaxValue (double value) { return new OneOrManyMaxValue (new MaxValuedouble (value)); }
            public static implicit operator OneOrManyMaxValue (double[] values) { return new OneOrManyMaxValue (values.Select(v => (IMaxValue) new MaxValuedouble (v))); }
            public static implicit operator OneOrManyMaxValue (List<double> values) { return new OneOrManyMaxValue (values.Select(v => (IMaxValue) new MaxValuedouble (v))); }
        }
        public struct MaxValuedouble : IMaxValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public MaxValuedouble (double value) { Value = value; }
            public static implicit operator MaxValuedouble (double value) { return new MaxValuedouble (value); }
        }

        public interface IMeasurementTechnique : IValue {}
        public interface IMeasurementTechnique<T> : IMeasurementTechnique { new T Value { get; } }
        public class OneOrManyMeasurementTechnique : OneOrMany<IMeasurementTechnique>
        {
            public OneOrManyMeasurementTechnique(IMeasurementTechnique item) : base(item) { }
            public OneOrManyMeasurementTechnique(IEnumerable<IMeasurementTechnique> items) : base(items) { }
            public static implicit operator OneOrManyMeasurementTechnique (string value) { return new OneOrManyMeasurementTechnique (new MeasurementTechniquestring (value)); }
            public static implicit operator OneOrManyMeasurementTechnique (string[] values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniquestring (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (List<string> values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniquestring (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (Uri value) { return new OneOrManyMeasurementTechnique (new MeasurementTechniqueUri (value)); }
            public static implicit operator OneOrManyMeasurementTechnique (Uri[] values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniqueUri (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (List<Uri> values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniqueUri (v))); }
        }
        public struct MeasurementTechniquestring : IMeasurementTechnique<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MeasurementTechniquestring (string value) { Value = value; }
            public static implicit operator MeasurementTechniquestring (string value) { return new MeasurementTechniquestring (value); }
        }
        public struct MeasurementTechniqueUri : IMeasurementTechnique<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MeasurementTechniqueUri (Uri value) { Value = value; }
            public static implicit operator MeasurementTechniqueUri (Uri value) { return new MeasurementTechniqueUri (value); }
        }

        public interface IMinValue : IValue {}
        public interface IMinValue<T> : IMinValue { new T Value { get; } }
        public class OneOrManyMinValue : OneOrMany<IMinValue>
        {
            public OneOrManyMinValue(IMinValue item) : base(item) { }
            public OneOrManyMinValue(IEnumerable<IMinValue> items) : base(items) { }
            public static implicit operator OneOrManyMinValue (double value) { return new OneOrManyMinValue (new MinValuedouble (value)); }
            public static implicit operator OneOrManyMinValue (double[] values) { return new OneOrManyMinValue (values.Select(v => (IMinValue) new MinValuedouble (v))); }
            public static implicit operator OneOrManyMinValue (List<double> values) { return new OneOrManyMinValue (values.Select(v => (IMinValue) new MinValuedouble (v))); }
        }
        public struct MinValuedouble : IMinValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public MinValuedouble (double value) { Value = value; }
            public static implicit operator MinValuedouble (double value) { return new MinValuedouble (value); }
        }

        public interface IPropertyID : IValue {}
        public interface IPropertyID<T> : IPropertyID { new T Value { get; } }
        public class OneOrManyPropertyID : OneOrMany<IPropertyID>
        {
            public OneOrManyPropertyID(IPropertyID item) : base(item) { }
            public OneOrManyPropertyID(IEnumerable<IPropertyID> items) : base(items) { }
            public static implicit operator OneOrManyPropertyID (string value) { return new OneOrManyPropertyID (new PropertyIDstring (value)); }
            public static implicit operator OneOrManyPropertyID (string[] values) { return new OneOrManyPropertyID (values.Select(v => (IPropertyID) new PropertyIDstring (v))); }
            public static implicit operator OneOrManyPropertyID (List<string> values) { return new OneOrManyPropertyID (values.Select(v => (IPropertyID) new PropertyIDstring (v))); }
            public static implicit operator OneOrManyPropertyID (Uri value) { return new OneOrManyPropertyID (new PropertyIDUri (value)); }
            public static implicit operator OneOrManyPropertyID (Uri[] values) { return new OneOrManyPropertyID (values.Select(v => (IPropertyID) new PropertyIDUri (v))); }
            public static implicit operator OneOrManyPropertyID (List<Uri> values) { return new OneOrManyPropertyID (values.Select(v => (IPropertyID) new PropertyIDUri (v))); }
        }
        public struct PropertyIDstring : IPropertyID<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PropertyIDstring (string value) { Value = value; }
            public static implicit operator PropertyIDstring (string value) { return new PropertyIDstring (value); }
        }
        public struct PropertyIDUri : IPropertyID<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public PropertyIDUri (Uri value) { Value = value; }
            public static implicit operator PropertyIDUri (Uri value) { return new PropertyIDUri (value); }
        }

        public interface IUnitCode : IValue {}
        public interface IUnitCode<T> : IUnitCode { new T Value { get; } }
        public class OneOrManyUnitCode : OneOrMany<IUnitCode>
        {
            public OneOrManyUnitCode(IUnitCode item) : base(item) { }
            public OneOrManyUnitCode(IEnumerable<IUnitCode> items) : base(items) { }
            public static implicit operator OneOrManyUnitCode (string value) { return new OneOrManyUnitCode (new UnitCodestring (value)); }
            public static implicit operator OneOrManyUnitCode (string[] values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodestring (v))); }
            public static implicit operator OneOrManyUnitCode (List<string> values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodestring (v))); }
            public static implicit operator OneOrManyUnitCode (Uri value) { return new OneOrManyUnitCode (new UnitCodeUri (value)); }
            public static implicit operator OneOrManyUnitCode (Uri[] values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodeUri (v))); }
            public static implicit operator OneOrManyUnitCode (List<Uri> values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodeUri (v))); }
        }
        public struct UnitCodestring : IUnitCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UnitCodestring (string value) { Value = value; }
            public static implicit operator UnitCodestring (string value) { return new UnitCodestring (value); }
        }
        public struct UnitCodeUri : IUnitCode<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public UnitCodeUri (Uri value) { Value = value; }
            public static implicit operator UnitCodeUri (Uri value) { return new UnitCodeUri (value); }
        }

        public interface IUnitText : IValue {}
        public interface IUnitText<T> : IUnitText { new T Value { get; } }
        public class OneOrManyUnitText : OneOrMany<IUnitText>
        {
            public OneOrManyUnitText(IUnitText item) : base(item) { }
            public OneOrManyUnitText(IEnumerable<IUnitText> items) : base(items) { }
            public static implicit operator OneOrManyUnitText (string value) { return new OneOrManyUnitText (new UnitTextstring (value)); }
            public static implicit operator OneOrManyUnitText (string[] values) { return new OneOrManyUnitText (values.Select(v => (IUnitText) new UnitTextstring (v))); }
            public static implicit operator OneOrManyUnitText (List<string> values) { return new OneOrManyUnitText (values.Select(v => (IUnitText) new UnitTextstring (v))); }
        }
        public struct UnitTextstring : IUnitText<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UnitTextstring (string value) { Value = value; }
            public static implicit operator UnitTextstring (string value) { return new UnitTextstring (value); }
        }

        public interface IAValue : IValue {}
        public interface IAValue<T> : IAValue { new T Value { get; } }
        public class OneOrManyAValue : OneOrMany<IAValue>
        {
            public OneOrManyAValue(IAValue item) : base(item) { }
            public OneOrManyAValue(IEnumerable<IAValue> items) : base(items) { }
            public static implicit operator OneOrManyAValue (bool value) { return new OneOrManyAValue (new AValuebool (value)); }
            public static implicit operator OneOrManyAValue (bool[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuebool (v))); }
            public static implicit operator OneOrManyAValue (List<bool> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuebool (v))); }
            public static implicit operator OneOrManyAValue (double value) { return new OneOrManyAValue (new AValuedouble (value)); }
            public static implicit operator OneOrManyAValue (double[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuedouble (v))); }
            public static implicit operator OneOrManyAValue (List<double> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuedouble (v))); }
            public static implicit operator OneOrManyAValue (StructuredValue value) { return new OneOrManyAValue (new AValueStructuredValue (value)); }
            public static implicit operator OneOrManyAValue (StructuredValue[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValueStructuredValue (v))); }
            public static implicit operator OneOrManyAValue (List<StructuredValue> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValueStructuredValue (v))); }
            public static implicit operator OneOrManyAValue (string value) { return new OneOrManyAValue (new AValuestring (value)); }
            public static implicit operator OneOrManyAValue (string[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuestring (v))); }
            public static implicit operator OneOrManyAValue (List<string> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuestring (v))); }
        }
        public struct AValuebool : IAValue<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public AValuebool (bool value) { Value = value; }
            public static implicit operator AValuebool (bool value) { return new AValuebool (value); }
        }
        public struct AValuedouble : IAValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public AValuedouble (double value) { Value = value; }
            public static implicit operator AValuedouble (double value) { return new AValuedouble (value); }
        }
        public struct AValueStructuredValue : IAValue<StructuredValue>
        {
            object IValue.Value => this.Value;
            public StructuredValue Value { get; }
            public AValueStructuredValue (StructuredValue value) { Value = value; }
            public static implicit operator AValueStructuredValue (StructuredValue value) { return new AValueStructuredValue (value); }
        }
        public struct AValuestring : IAValue<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AValuestring (string value) { Value = value; }
            public static implicit operator AValuestring (string value) { return new AValuestring (value); }
        }

        public interface IValueReference : IValue {}
        public interface IValueReference<T> : IValueReference { new T Value { get; } }
        public class OneOrManyValueReference : OneOrMany<IValueReference>
        {
            public OneOrManyValueReference(IValueReference item) : base(item) { }
            public OneOrManyValueReference(IEnumerable<IValueReference> items) : base(items) { }
            public static implicit operator OneOrManyValueReference (PropertyValue value) { return new OneOrManyValueReference (new ValueReferencePropertyValue (value)); }
            public static implicit operator OneOrManyValueReference (PropertyValue[] values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferencePropertyValue (v))); }
            public static implicit operator OneOrManyValueReference (List<PropertyValue> values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferencePropertyValue (v))); }
            public static implicit operator OneOrManyValueReference (QuantitativeValue value) { return new OneOrManyValueReference (new ValueReferenceQuantitativeValue (value)); }
            public static implicit operator OneOrManyValueReference (QuantitativeValue[] values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferenceQuantitativeValue (v))); }
            public static implicit operator OneOrManyValueReference (List<QuantitativeValue> values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferenceQuantitativeValue (v))); }
            public static implicit operator OneOrManyValueReference (StructuredValue value) { return new OneOrManyValueReference (new ValueReferenceStructuredValue (value)); }
            public static implicit operator OneOrManyValueReference (StructuredValue[] values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferenceStructuredValue (v))); }
            public static implicit operator OneOrManyValueReference (List<StructuredValue> values) { return new OneOrManyValueReference (values.Select(v => (IValueReference) new ValueReferenceStructuredValue (v))); }
        }
        public struct ValueReferencePropertyValue : IValueReference<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public ValueReferencePropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator ValueReferencePropertyValue (PropertyValue value) { return new ValueReferencePropertyValue (value); }
        }
        public struct ValueReferenceQuantitativeValue : IValueReference<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public ValueReferenceQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator ValueReferenceQuantitativeValue (QuantitativeValue value) { return new ValueReferenceQuantitativeValue (value); }
        }
        public struct ValueReferenceStructuredValue : IValueReference<StructuredValue>
        {
            object IValue.Value => this.Value;
            public StructuredValue Value { get; }
            public ValueReferenceStructuredValue (StructuredValue value) { Value = value; }
            public static implicit operator ValueReferenceStructuredValue (StructuredValue value) { return new ValueReferenceStructuredValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValue";

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 306)]
        public OneOrManyMaxValue MaxValue { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 307)]
        public OneOrManyMeasurementTechnique MeasurementTechnique { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        public OneOrManyMinValue MinValue { get; set; }

        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        [DataMember(Name = "propertyID", Order = 309)]
        public OneOrManyPropertyID PropertyID { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 310)]
        public OneOrManyUnitCode UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 311)]
        public OneOrManyUnitText UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 312)]
        public OneOrManyAValue Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 313)]
        public OneOrManyValueReference ValueReference { get; set; }
    }
}
