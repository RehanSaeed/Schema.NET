namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An amusement park.
    /// </summary>
    public partial interface IAmusementPark : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An amusement park.
    /// </summary>
    [DataContract]
    public partial class AmusementPark : EntertainmentBusiness, IAmusementPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AmusementPark";
    }
}
