namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    [DataContract]
    public partial class QuantitativeValue : StructuredValue
    {
        public interface IAdditionalProperty : IValue {}
        public interface IAdditionalProperty<T> : IAdditionalProperty { new T Value { get; } }
        public class OneOrManyAdditionalProperty : OneOrMany<IAdditionalProperty>
        {
            public OneOrManyAdditionalProperty(IAdditionalProperty item) : base(item) { }
            public OneOrManyAdditionalProperty(IEnumerable<IAdditionalProperty> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue value) { return new OneOrManyAdditionalProperty (new AdditionalPropertyPropertyValue (value)); }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue[] values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
            public static implicit operator OneOrManyAdditionalProperty (List<PropertyValue> values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
        }
        public struct AdditionalPropertyPropertyValue : IAdditionalProperty<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public AdditionalPropertyPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator AdditionalPropertyPropertyValue (PropertyValue value) { return new AdditionalPropertyPropertyValue (value); }
        }

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
        public override string Type => "QuantitativeValue";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 306)]
        public OneOrManyAdditionalProperty AdditionalProperty { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 307)]
        public OneOrManyMaxValue MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        public OneOrManyMinValue MinValue { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        public OneOrManyUnitCode UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        public OneOrManyUnitText UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 311)]
        public OneOrManyAValue Value { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 312)]
        public OneOrManyValueReference ValueReference { get; set; }
    }
}
