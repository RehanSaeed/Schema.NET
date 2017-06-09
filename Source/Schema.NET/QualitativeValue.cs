namespace Schema.NET
{
    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
    public enum QualitativeValue
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        additionalProperty,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is equal to the object.
        /// </summary>
        equal,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is greater than the object.
        /// </summary>
        greater,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
        /// </summary>
        greaterOrEqual,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
        /// </summary>
        lesser,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
        /// </summary>
        lesserOrEqual,

        /// <summary>
        /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
        /// </summary>
        nonEqual,

        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        valueReference
    }
}
