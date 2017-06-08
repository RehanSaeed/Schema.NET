namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated status values for Order.
    /// </summary>
    [DataContract]
    public class OrderStatus : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OrderStatus";
    }
}
