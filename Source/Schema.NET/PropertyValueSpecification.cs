namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Property value specification.
    /// </summary>
    [DataContract]
    public class PropertyValueSpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PropertyValueSpecification";

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [DataMember(Name = "defaultValue")]
        public object DefaultValue { get; protected set; }

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [IgnoreDataMember]
        public Thing DefaultValueThing
        {
            get => this.DefaultValue as Thing;
            set => this.DefaultValue = value;
        }

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [IgnoreDataMember]
        public string DefaultValueText
        {
            get => this.DefaultValue as string;
            set => this.DefaultValue = value;
        }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        [DataMember(Name = "valuePattern")]
        public string ValuePattern { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        [DataMember(Name = "stepValue")]
        public decimal StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMaxLength")]
        public decimal ValueMaxLength { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        [DataMember(Name = "readonlyValue")]
        public bool ReadonlyValue { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        [DataMember(Name = "valueMinLength")]
        public decimal ValueMinLength { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue")]
        public decimal MaxValue { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        [DataMember(Name = "valueName")]
        public string ValueName { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        [DataMember(Name = "multipleValues")]
        public bool MultipleValues { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue")]
        public decimal MinValue { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        [DataMember(Name = "valueRequired")]
        public bool ValueRequired { get; set; }
    }
}
