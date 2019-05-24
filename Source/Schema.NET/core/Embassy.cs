namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An embassy.
    /// </summary>
    public partial interface IEmbassy : IGovernmentBuilding
    {
    }

    /// <summary>
    /// An embassy.
    /// </summary>
    [DataContract]
    public partial class Embassy : GovernmentBuilding, IEmbassy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Embassy";
    }
}
