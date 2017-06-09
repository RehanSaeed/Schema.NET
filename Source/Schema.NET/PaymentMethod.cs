namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase...
    /// </summary>
    [DataContract]
    public class PaymentMethod : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaymentMethod";
    }
}
