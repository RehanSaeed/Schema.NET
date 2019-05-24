namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A graveyard.
    /// </summary>
    public partial interface ICemetery : ICivicStructure
    {
    }

    /// <summary>
    /// A graveyard.
    /// </summary>
    [DataContract]
    public partial class Cemetery : CivicStructure, ICemetery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Cemetery";
    }
}
