namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e...
    /// </summary>
    [DataContract]
    public partial class ProgramMembership : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProgramMembership";

        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        [DataMember(Name = "hostingOrganization", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MembershipNumber { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProgramName { get; set; }
    }
}
