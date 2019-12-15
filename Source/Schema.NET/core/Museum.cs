namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A museum.
    /// </summary>
    public partial interface IMuseum : ICivicStructure
    {
    }

    /// <summary>
    /// A museum.
    /// </summary>
    [DataContract]
    public partial class Museum : CivicStructure, IMuseum, IEquatable<Museum>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Museum";
    }
}
