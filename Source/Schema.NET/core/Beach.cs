namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Beach.
    /// </summary>
    public partial interface IBeach : ICivicStructure
    {
    }

    /// <summary>
    /// Beach.
    /// </summary>
    [DataContract]
    public partial class Beach : CivicStructure, IBeach
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Beach";
    }
}
