namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A train station.
    /// </summary>
    public partial interface ITrainStation : ICivicStructure
    {
    }

    /// <summary>
    /// A train station.
    /// </summary>
    [DataContract]
    public partial class TrainStation : CivicStructure, ITrainStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainStation";
    }
}
