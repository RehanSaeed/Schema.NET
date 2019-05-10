namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A stadium.
    /// </summary>
    public partial interface IStadiumOrArena : ICivicStructureAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A stadium.
    /// </summary>
    [DataContract]
    public partial class StadiumOrArena : CivicStructureAndSportsActivityLocation, IStadiumOrArena
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "StadiumOrArena";
    }
}
