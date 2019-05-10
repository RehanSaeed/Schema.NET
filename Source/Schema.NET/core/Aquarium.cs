namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Aquarium.
    /// </summary>
    public partial interface IAquarium : ICivicStructure
    {
    }

    /// <summary>
    /// Aquarium.
    /// </summary>
    [DataContract]
    public partial class Aquarium : CivicStructure, IAquarium
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Aquarium";
    }
}
