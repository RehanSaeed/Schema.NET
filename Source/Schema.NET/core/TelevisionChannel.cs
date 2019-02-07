namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class TelevisionChannel : BroadcastChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TelevisionChannel";
    }
}
