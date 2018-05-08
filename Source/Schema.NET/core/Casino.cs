namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A casino.
    /// </summary>
    public partial interface ICasino : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A casino.
    /// </summary>
    [DataContract]
    public partial class Casino : EntertainmentBusiness, ICasino
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Casino";
    }
}
