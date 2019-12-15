namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial interface ITelevisionChannel : IBroadcastChannel
    {
    }

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class TelevisionChannel : BroadcastChannel, ITelevisionChannel, IEquatable<TelevisionChannel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TelevisionChannel";
    }
}
