namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
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
        [DataMember(Name = "hostingOrganization", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? MembershipNumber { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ProgramName { get; set; }
    }
}
