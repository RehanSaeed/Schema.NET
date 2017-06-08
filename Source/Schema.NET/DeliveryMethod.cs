namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer...
    /// </summary>
    [DataContract]
    public class DeliveryMethod : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DeliveryMethod";
    }
}
