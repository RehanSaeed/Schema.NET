namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Quantity: Duration (use ISO 8601 duration format).
    /// </summary>
    [DataContract]
    public partial class Duration : Quantity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Duration";
    }
}
