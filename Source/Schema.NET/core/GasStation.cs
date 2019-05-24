namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A gas station.
    /// </summary>
    public partial interface IGasStation : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A gas station.
    /// </summary>
    [DataContract]
    public partial class GasStation : AutomotiveBusiness, IGasStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GasStation";
    }
}
