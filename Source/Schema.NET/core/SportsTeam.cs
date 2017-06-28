namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    [DataContract]
    public partial class SportsTeam : SportsOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [DataMember(Name = "athlete", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [DataMember(Name = "coach", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Coach { get; set; }
    }
}
