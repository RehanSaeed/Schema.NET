namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
    [DataContract]
    public class QualitativeValue : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QualitativeValue";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 2)]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is equal to the object.
        /// </summary>
        [DataMember(Name = "equal", Order = 3)]
        public QualitativeValue Equal { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is greater than the object.
        /// </summary>
        [DataMember(Name = "greater", Order = 4)]
        public QualitativeValue Greater { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
        /// </summary>
        [DataMember(Name = "greaterOrEqual", Order = 5)]
        public QualitativeValue GreaterOrEqual { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
        /// </summary>
        [DataMember(Name = "lesser", Order = 6)]
        public QualitativeValue Lesser { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
        /// </summary>
        [DataMember(Name = "lesserOrEqual", Order = 7)]
        public QualitativeValue LesserOrEqual { get; set; }

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
        /// </summary>
        [DataMember(Name = "nonEqual", Order = 8)]
        public QualitativeValue NonEqual { get; set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [DataMember(Name = "valueReference", Order = 9)]
        public object ValueReference { get; protected set; }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [IgnoreDataMember]
        public QualitativeValue ValueReferenceQualitativeValue
        {
            get => this.ValueReference as QualitativeValue;
            set => this.ValueReference = value;
        }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue ValueReferenceQuantitativeValue
        {
            get => this.ValueReference as QuantitativeValue;
            set => this.ValueReference = value;
        }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [IgnoreDataMember]
        public StructuredValue ValueReferenceStructuredValue
        {
            get => this.ValueReference as StructuredValue;
            set => this.ValueReference = value;
        }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [IgnoreDataMember]
        public Enumeration ValueReferenceEnumeration
        {
            get => this.ValueReference as Enumeration;
            set => this.ValueReference = value;
        }

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [IgnoreDataMember]
        public PropertyValue ValueReferencePropertyValue
        {
            get => this.ValueReference as PropertyValue;
            set => this.ValueReference = value;
        }
    }
}
