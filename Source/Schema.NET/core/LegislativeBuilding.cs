namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    public partial interface ILegislativeBuilding : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    [DataContract]
    public partial class LegislativeBuilding : GovernmentBuilding, ILegislativeBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LegislativeBuilding";
    }
}
