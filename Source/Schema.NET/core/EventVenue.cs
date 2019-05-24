namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An event venue.
    /// </summary>
    public partial interface IEventVenue : ICivicStructure
    {
    }

    /// <summary>
    /// An event venue.
    /// </summary>
    [DataContract]
    public partial class EventVenue : CivicStructure, IEventVenue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EventVenue";
    }
}
