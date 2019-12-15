namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A government building.
    /// </summary>
    public partial interface IGovernmentBuilding : ICivicStructure
    {
    }

    /// <summary>
    /// A government building.
    /// </summary>
    [DataContract]
    public partial class GovernmentBuilding : CivicStructure, IGovernmentBuilding, IEquatable<GovernmentBuilding>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentBuilding";
    }
}
