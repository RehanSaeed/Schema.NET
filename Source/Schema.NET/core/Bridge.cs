namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bridge.
    /// </summary>
    public partial interface IBridge : ICivicStructure
    {
    }

    /// <summary>
    /// A bridge.
    /// </summary>
    [DataContract]
    public partial class Bridge : CivicStructure, IBridge, IEquatable<Bridge>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Bridge";
    }
}
