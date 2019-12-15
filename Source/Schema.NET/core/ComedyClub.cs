namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A comedy club.
    /// </summary>
    public partial interface IComedyClub : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A comedy club.
    /// </summary>
    [DataContract]
    public partial class ComedyClub : EntertainmentBusiness, IComedyClub, IEquatable<ComedyClub>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComedyClub";
    }
}
