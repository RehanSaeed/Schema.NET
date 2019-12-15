namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    public partial interface ITaxiService : IService
    {
    }

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    [DataContract]
    public partial class TaxiService : Service, ITaxiService, IEquatable<TaxiService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiService";
    }
}
