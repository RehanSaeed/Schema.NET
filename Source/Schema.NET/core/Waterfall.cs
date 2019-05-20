namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    public partial interface IWaterfall : IBodyOfWater
    {
    }

    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    [DataContract]
    public partial class Waterfall : BodyOfWater, IWaterfall
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Waterfall";
    }
}
