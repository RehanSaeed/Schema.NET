namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    [DataContract]
    public class MotorcycleRepair : AutomotiveBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MotorcycleRepair";
    }
}
