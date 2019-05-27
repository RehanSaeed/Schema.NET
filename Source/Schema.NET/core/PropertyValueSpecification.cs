﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Property value specification.
    /// </summary>
    public partial interface IPropertyValueSpecification : IIntangible
    {
        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        Values<string, IThing> DefaultValue { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        OneOrMany<bool?> MultipleValues { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        OneOrMany<bool?> ReadonlyValue { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        OneOrMany<double?> StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        OneOrMany<double?> ValueMaxLength { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        OneOrMany<double?> ValueMinLength { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        OneOrMany<string> ValueName { get; set; }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        OneOrMany<string> ValuePattern { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        OneOrMany<bool?> ValueRequired { get; set; }
    }

    /// <summary>
    /// A Property value specification.
    /// </summary>
    [DataContract]
    public partial class PropertyValueSpecification : Intangible, IPropertyValueSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValueSpecification";

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [DataMember(Name = "defaultValue", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing> DefaultValue { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        [DataMember(Name = "multipleValues", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> MultipleValues { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        [DataMember(Name = "readonlyValue", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> ReadonlyValue { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        [DataMember(Name = "stepValue", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMaxLength", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> ValueMaxLength { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMinLength", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> ValueMinLength { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        [DataMember(Name = "valueName", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ValueName { get; set; }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        [DataMember(Name = "valuePattern", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ValuePattern { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        [DataMember(Name = "valueRequired", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> ValueRequired { get; set; }
    }
}
