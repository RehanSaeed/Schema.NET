namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    public partial interface IPublicSwimmingPool : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    [DataContract]
    public partial class PublicSwimmingPool : SportsActivityLocation, IPublicSwimmingPool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicSwimmingPool";
    }
}
