using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    [DataContract]
    public partial class LandmarksOrHistoricalBuildings : Place
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LandmarksOrHistoricalBuildings";
    }
}
