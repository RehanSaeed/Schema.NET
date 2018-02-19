using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;/p&gt;
    /// &lt;p&gt;Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// </summary>
    [DataContract]
    public partial class PropertyValue : StructuredValue
    {
        public interface IMeasurementTechnique : IWrapper { }
        public interface IMeasurementTechnique<T> : IMeasurementTechnique { new T Data { get; set; } }
        public class MeasurementTechniquestring : IMeasurementTechnique<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public MeasurementTechniquestring () { }
            public MeasurementTechniquestring (string data) { Data = data; }
            public static implicit operator MeasurementTechniquestring (string data) { return new MeasurementTechniquestring (data); }
        }

        public class MeasurementTechniqueUri : IMeasurementTechnique<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public MeasurementTechniqueUri () { }
            public MeasurementTechniqueUri (Uri data) { Data = data; }
            public static implicit operator MeasurementTechniqueUri (Uri data) { return new MeasurementTechniqueUri (data); }
        }


        public interface IPropertyID : IWrapper { }
        public interface IPropertyID<T> : IPropertyID { new T Data { get; set; } }
        public class PropertyIDstring : IPropertyID<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PropertyIDstring () { }
            public PropertyIDstring (string data) { Data = data; }
            public static implicit operator PropertyIDstring (string data) { return new PropertyIDstring (data); }
        }

        public class PropertyIDUri : IPropertyID<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public PropertyIDUri () { }
            public PropertyIDUri (Uri data) { Data = data; }
            public static implicit operator PropertyIDUri (Uri data) { return new PropertyIDUri (data); }
        }


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
        public override string Type => "PropertyValue";

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? MaxValue { get; set; } 

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;/p&gt;
        /// &lt;p&gt;For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;/p&gt;
        /// &lt;p&gt;If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;/p&gt;
        /// &lt;p&gt;If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMeasurementTechnique>? MeasurementTechnique { get; set; } //string, Uri

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? MinValue { get; set; } 

        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        [DataMember(Name = "propertyID", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPropertyID>? PropertyID { get; set; } //string, Uri

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IUnitCode>? UnitCode { get; set; } //string, Uri

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UnitText { get; set; } 

        /// <summary>
        /// &lt;p&gt;The value of the quantitative value or property value node.&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IValue>? Value { get; set; } //bool?, double?, StructuredValue, string

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IValueReference>? ValueReference { get; set; } //PropertyValue, QuantitativeValue, StructuredValue
    }
}
