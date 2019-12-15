namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A playground.
    /// </summary>
    public partial interface IPlayground : ICivicStructure
    {
    }

    /// <summary>
    /// A playground.
    /// </summary>
    [DataContract]
    public partial class Playground : CivicStructure, IPlayground, IEquatable<Playground>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Playground";
    }
}
