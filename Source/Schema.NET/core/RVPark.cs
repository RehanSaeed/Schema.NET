namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    public partial interface IRVPark : ICivicStructure
    {
    }

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    [DataContract]
    public partial class RVPark : CivicStructure, IRVPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RVPark";
    }
}
