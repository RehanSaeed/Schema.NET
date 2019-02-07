namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Property value specification.
    /// </summary>
    [DataContract]
    public partial class PropertyValueSpecification : Intangible
    {
        public interface IDefaultValue : IValue {}
        public interface IDefaultValue<T> : IDefaultValue { new T Value { get; } }
        public class OneOrManyDefaultValue : OneOrMany<IDefaultValue>
        {
            public OneOrManyDefaultValue(IDefaultValue item) : base(item) { }
            public OneOrManyDefaultValue(IEnumerable<IDefaultValue> items) : base(items) { }
            public static implicit operator OneOrManyDefaultValue (string value) { return new OneOrManyDefaultValue (new DefaultValuestring (value)); }
            public static implicit operator OneOrManyDefaultValue (string[] values) { return new OneOrManyDefaultValue (values.Select(v => (IDefaultValue) new DefaultValuestring (v))); }
            public static implicit operator OneOrManyDefaultValue (List<string> values) { return new OneOrManyDefaultValue (values.Select(v => (IDefaultValue) new DefaultValuestring (v))); }
            public static implicit operator OneOrManyDefaultValue (Thing value) { return new OneOrManyDefaultValue (new DefaultValueThing (value)); }
            public static implicit operator OneOrManyDefaultValue (Thing[] values) { return new OneOrManyDefaultValue (values.Select(v => (IDefaultValue) new DefaultValueThing (v))); }
            public static implicit operator OneOrManyDefaultValue (List<Thing> values) { return new OneOrManyDefaultValue (values.Select(v => (IDefaultValue) new DefaultValueThing (v))); }
        }
        public struct DefaultValuestring : IDefaultValue<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DefaultValuestring (string value) { Value = value; }
            public static implicit operator DefaultValuestring (string value) { return new DefaultValuestring (value); }
        }
        public struct DefaultValueThing : IDefaultValue<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public DefaultValueThing (Thing value) { Value = value; }
            public static implicit operator DefaultValueThing (Thing value) { return new DefaultValueThing (value); }
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

        public interface IMultipleValues : IValue {}
        public interface IMultipleValues<T> : IMultipleValues { new T Value { get; } }
        public class OneOrManyMultipleValues : OneOrMany<IMultipleValues>
        {
            public OneOrManyMultipleValues(IMultipleValues item) : base(item) { }
            public OneOrManyMultipleValues(IEnumerable<IMultipleValues> items) : base(items) { }
            public static implicit operator OneOrManyMultipleValues (bool value) { return new OneOrManyMultipleValues (new MultipleValuesbool (value)); }
            public static implicit operator OneOrManyMultipleValues (bool[] values) { return new OneOrManyMultipleValues (values.Select(v => (IMultipleValues) new MultipleValuesbool (v))); }
            public static implicit operator OneOrManyMultipleValues (List<bool> values) { return new OneOrManyMultipleValues (values.Select(v => (IMultipleValues) new MultipleValuesbool (v))); }
        }
        public struct MultipleValuesbool : IMultipleValues<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public MultipleValuesbool (bool value) { Value = value; }
            public static implicit operator MultipleValuesbool (bool value) { return new MultipleValuesbool (value); }
        }

        public interface IReadonlyValue : IValue {}
        public interface IReadonlyValue<T> : IReadonlyValue { new T Value { get; } }
        public class OneOrManyReadonlyValue : OneOrMany<IReadonlyValue>
        {
            public OneOrManyReadonlyValue(IReadonlyValue item) : base(item) { }
            public OneOrManyReadonlyValue(IEnumerable<IReadonlyValue> items) : base(items) { }
            public static implicit operator OneOrManyReadonlyValue (bool value) { return new OneOrManyReadonlyValue (new ReadonlyValuebool (value)); }
            public static implicit operator OneOrManyReadonlyValue (bool[] values) { return new OneOrManyReadonlyValue (values.Select(v => (IReadonlyValue) new ReadonlyValuebool (v))); }
            public static implicit operator OneOrManyReadonlyValue (List<bool> values) { return new OneOrManyReadonlyValue (values.Select(v => (IReadonlyValue) new ReadonlyValuebool (v))); }
        }
        public struct ReadonlyValuebool : IReadonlyValue<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public ReadonlyValuebool (bool value) { Value = value; }
            public static implicit operator ReadonlyValuebool (bool value) { return new ReadonlyValuebool (value); }
        }

        public interface IStepValue : IValue {}
        public interface IStepValue<T> : IStepValue { new T Value { get; } }
        public class OneOrManyStepValue : OneOrMany<IStepValue>
        {
            public OneOrManyStepValue(IStepValue item) : base(item) { }
            public OneOrManyStepValue(IEnumerable<IStepValue> items) : base(items) { }
            public static implicit operator OneOrManyStepValue (double value) { return new OneOrManyStepValue (new StepValuedouble (value)); }
            public static implicit operator OneOrManyStepValue (double[] values) { return new OneOrManyStepValue (values.Select(v => (IStepValue) new StepValuedouble (v))); }
            public static implicit operator OneOrManyStepValue (List<double> values) { return new OneOrManyStepValue (values.Select(v => (IStepValue) new StepValuedouble (v))); }
        }
        public struct StepValuedouble : IStepValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public StepValuedouble (double value) { Value = value; }
            public static implicit operator StepValuedouble (double value) { return new StepValuedouble (value); }
        }

        public interface IValueMaxLength : IValue {}
        public interface IValueMaxLength<T> : IValueMaxLength { new T Value { get; } }
        public class OneOrManyValueMaxLength : OneOrMany<IValueMaxLength>
        {
            public OneOrManyValueMaxLength(IValueMaxLength item) : base(item) { }
            public OneOrManyValueMaxLength(IEnumerable<IValueMaxLength> items) : base(items) { }
            public static implicit operator OneOrManyValueMaxLength (double value) { return new OneOrManyValueMaxLength (new ValueMaxLengthdouble (value)); }
            public static implicit operator OneOrManyValueMaxLength (double[] values) { return new OneOrManyValueMaxLength (values.Select(v => (IValueMaxLength) new ValueMaxLengthdouble (v))); }
            public static implicit operator OneOrManyValueMaxLength (List<double> values) { return new OneOrManyValueMaxLength (values.Select(v => (IValueMaxLength) new ValueMaxLengthdouble (v))); }
        }
        public struct ValueMaxLengthdouble : IValueMaxLength<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public ValueMaxLengthdouble (double value) { Value = value; }
            public static implicit operator ValueMaxLengthdouble (double value) { return new ValueMaxLengthdouble (value); }
        }

        public interface IValueMinLength : IValue {}
        public interface IValueMinLength<T> : IValueMinLength { new T Value { get; } }
        public class OneOrManyValueMinLength : OneOrMany<IValueMinLength>
        {
            public OneOrManyValueMinLength(IValueMinLength item) : base(item) { }
            public OneOrManyValueMinLength(IEnumerable<IValueMinLength> items) : base(items) { }
            public static implicit operator OneOrManyValueMinLength (double value) { return new OneOrManyValueMinLength (new ValueMinLengthdouble (value)); }
            public static implicit operator OneOrManyValueMinLength (double[] values) { return new OneOrManyValueMinLength (values.Select(v => (IValueMinLength) new ValueMinLengthdouble (v))); }
            public static implicit operator OneOrManyValueMinLength (List<double> values) { return new OneOrManyValueMinLength (values.Select(v => (IValueMinLength) new ValueMinLengthdouble (v))); }
        }
        public struct ValueMinLengthdouble : IValueMinLength<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public ValueMinLengthdouble (double value) { Value = value; }
            public static implicit operator ValueMinLengthdouble (double value) { return new ValueMinLengthdouble (value); }
        }

        public interface IValueName : IValue {}
        public interface IValueName<T> : IValueName { new T Value { get; } }
        public class OneOrManyValueName : OneOrMany<IValueName>
        {
            public OneOrManyValueName(IValueName item) : base(item) { }
            public OneOrManyValueName(IEnumerable<IValueName> items) : base(items) { }
            public static implicit operator OneOrManyValueName (string value) { return new OneOrManyValueName (new ValueNamestring (value)); }
            public static implicit operator OneOrManyValueName (string[] values) { return new OneOrManyValueName (values.Select(v => (IValueName) new ValueNamestring (v))); }
            public static implicit operator OneOrManyValueName (List<string> values) { return new OneOrManyValueName (values.Select(v => (IValueName) new ValueNamestring (v))); }
        }
        public struct ValueNamestring : IValueName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ValueNamestring (string value) { Value = value; }
            public static implicit operator ValueNamestring (string value) { return new ValueNamestring (value); }
        }

        public interface IValuePattern : IValue {}
        public interface IValuePattern<T> : IValuePattern { new T Value { get; } }
        public class OneOrManyValuePattern : OneOrMany<IValuePattern>
        {
            public OneOrManyValuePattern(IValuePattern item) : base(item) { }
            public OneOrManyValuePattern(IEnumerable<IValuePattern> items) : base(items) { }
            public static implicit operator OneOrManyValuePattern (string value) { return new OneOrManyValuePattern (new ValuePatternstring (value)); }
            public static implicit operator OneOrManyValuePattern (string[] values) { return new OneOrManyValuePattern (values.Select(v => (IValuePattern) new ValuePatternstring (v))); }
            public static implicit operator OneOrManyValuePattern (List<string> values) { return new OneOrManyValuePattern (values.Select(v => (IValuePattern) new ValuePatternstring (v))); }
        }
        public struct ValuePatternstring : IValuePattern<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ValuePatternstring (string value) { Value = value; }
            public static implicit operator ValuePatternstring (string value) { return new ValuePatternstring (value); }
        }

        public interface IValueRequired : IValue {}
        public interface IValueRequired<T> : IValueRequired { new T Value { get; } }
        public class OneOrManyValueRequired : OneOrMany<IValueRequired>
        {
            public OneOrManyValueRequired(IValueRequired item) : base(item) { }
            public OneOrManyValueRequired(IEnumerable<IValueRequired> items) : base(items) { }
            public static implicit operator OneOrManyValueRequired (bool value) { return new OneOrManyValueRequired (new ValueRequiredbool (value)); }
            public static implicit operator OneOrManyValueRequired (bool[] values) { return new OneOrManyValueRequired (values.Select(v => (IValueRequired) new ValueRequiredbool (v))); }
            public static implicit operator OneOrManyValueRequired (List<bool> values) { return new OneOrManyValueRequired (values.Select(v => (IValueRequired) new ValueRequiredbool (v))); }
        }
        public struct ValueRequiredbool : IValueRequired<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public ValueRequiredbool (bool value) { Value = value; }
            public static implicit operator ValueRequiredbool (bool value) { return new ValueRequiredbool (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValueSpecification";

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [DataMember(Name = "defaultValue", Order = 206)]
        public OneOrManyDefaultValue DefaultValue { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 207)]
        public OneOrManyMaxValue MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 208)]
        public OneOrManyMinValue MinValue { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        [DataMember(Name = "multipleValues", Order = 209)]
        public OneOrManyMultipleValues MultipleValues { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        [DataMember(Name = "readonlyValue", Order = 210)]
        public OneOrManyReadonlyValue ReadonlyValue { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        [DataMember(Name = "stepValue", Order = 211)]
        public OneOrManyStepValue StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMaxLength", Order = 212)]
        public OneOrManyValueMaxLength ValueMaxLength { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMinLength", Order = 213)]
        public OneOrManyValueMinLength ValueMinLength { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        [DataMember(Name = "valueName", Order = 214)]
        public OneOrManyValueName ValueName { get; set; }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        [DataMember(Name = "valuePattern", Order = 215)]
        public OneOrManyValuePattern ValuePattern { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        [DataMember(Name = "valueRequired", Order = 216)]
        public OneOrManyValueRequired ValueRequired { get; set; }
    }
}
