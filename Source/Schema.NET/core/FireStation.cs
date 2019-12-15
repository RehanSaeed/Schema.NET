namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    public partial interface IFireStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    [DataContract]
    public partial class FireStation : CivicStructureAndEmergencyService, IFireStation, IEquatable<FireStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FireStation";
    }
}
