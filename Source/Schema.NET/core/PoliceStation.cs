namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A police station.
    /// </summary>
    public partial interface IPoliceStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A police station.
    /// </summary>
    [DataContract]
    public partial class PoliceStation : CivicStructureAndEmergencyService, IPoliceStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PoliceStation";
    }
}
