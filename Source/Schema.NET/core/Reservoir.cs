namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    public partial interface IReservoir : IBodyOfWater
    {
    }

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    [DataContract]
    public partial class Reservoir : BodyOfWater, IReservoir
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Reservoir";
    }
}
