namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subway station.
    /// </summary>
    public partial interface ISubwayStation : ICivicStructure
    {
    }

    /// <summary>
    /// A subway station.
    /// </summary>
    [DataContract]
    public partial class SubwayStation : CivicStructure, ISubwayStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SubwayStation";
    }
}
