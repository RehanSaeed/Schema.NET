namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A car rental business.
    /// </summary>
    [DataContract]
    public class AutoRental : AutomotiveBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AutoRental";
    }
}
