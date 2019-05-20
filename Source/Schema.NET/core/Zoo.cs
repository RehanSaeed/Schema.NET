namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A zoo.
    /// </summary>
    public partial interface IZoo : ICivicStructure
    {
    }

    /// <summary>
    /// A zoo.
    /// </summary>
    [DataContract]
    public partial class Zoo : CivicStructure, IZoo
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Zoo";
    }
}
