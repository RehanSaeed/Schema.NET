namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sports club.
    /// </summary>
    public partial interface ISportsClub : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A sports club.
    /// </summary>
    [DataContract]
    public partial class SportsClub : SportsActivityLocation, ISportsClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsClub";
    }
}
