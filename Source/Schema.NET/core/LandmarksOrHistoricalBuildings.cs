namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    public partial interface ILandmarksOrHistoricalBuildings : IPlace
    {
    }

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    [DataContract]
    public partial class LandmarksOrHistoricalBuildings : Place, ILandmarksOrHistoricalBuildings
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LandmarksOrHistoricalBuildings";
    }
}
