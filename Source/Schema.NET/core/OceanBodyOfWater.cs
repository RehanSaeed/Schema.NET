namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    public partial interface IOceanBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    [DataContract]
    public partial class OceanBodyOfWater : BodyOfWater, IOceanBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OceanBodyOfWater";
    }
}
