namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    public partial interface IStructuredValue : IIntangible
    {
    }

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    [DataContract]
    public partial class StructuredValue : Intangible, IStructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "StructuredValue";
    }
}
