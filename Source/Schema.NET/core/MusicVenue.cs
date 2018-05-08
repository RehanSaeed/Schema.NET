namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music venue.
    /// </summary>
    public partial interface IMusicVenue : ICivicStructure
    {
    }

    /// <summary>
    /// A music venue.
    /// </summary>
    [DataContract]
    public partial class MusicVenue : CivicStructure, IMusicVenue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicVenue";
    }
}
