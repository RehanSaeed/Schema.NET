namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    [DataContract]
    public class StructuredValue : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "StructuredValue";
    }
}
