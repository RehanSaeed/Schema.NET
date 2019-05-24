namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    public partial interface IParkingFacility : ICivicStructure
    {
    }

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    [DataContract]
    public partial class ParkingFacility : CivicStructure, IParkingFacility
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParkingFacility";
    }
}
