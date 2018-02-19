using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    [DataContract]
    public partial class Reservoir : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Reservoir";
    }
}
