namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    public partial interface ISportsTeam : ISportsOrganization
    {
        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        OneOrMany<IPerson> Coach { get; set; }
    }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    [DataContract]
    public partial class SportsTeam : SportsOrganization, ISportsTeam
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [DataMember(Name = "athlete", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [DataMember(Name = "coach", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Coach { get; set; }
    }
}
