namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bus station.
    /// </summary>
    public partial interface IBusStation : ICivicStructure
    {
    }

    /// <summary>
    /// A bus station.
    /// </summary>
    [DataContract]
    public partial class BusStation : CivicStructure, IBusStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusStation";
    }
}
