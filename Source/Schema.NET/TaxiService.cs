namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel...
    /// </summary>
    [DataContract]
    public class TaxiService : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TaxiService";
    }
}
