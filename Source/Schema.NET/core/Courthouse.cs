namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A courthouse.
    /// </summary>
    public partial interface ICourthouse : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A courthouse.
    /// </summary>
    [DataContract]
    public partial class Courthouse : GovernmentBuilding, ICourthouse
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Courthouse";
    }
}
