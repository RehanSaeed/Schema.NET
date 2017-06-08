namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    [DataContract]
    public class SportsTeam : SportsOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [DataMember(Name = "athlete")]
        public Person Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [DataMember(Name = "coach")]
        public Person Coach { get; set; }
    }
}
