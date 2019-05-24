namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A park.
    /// </summary>
    public partial interface IPark : ICivicStructure
    {
    }

    /// <summary>
    /// A park.
    /// </summary>
    [DataContract]
    public partial class Park : CivicStructure, IPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Park";
    }
}
