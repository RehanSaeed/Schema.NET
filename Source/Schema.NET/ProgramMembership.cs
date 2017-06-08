namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e...
    /// </summary>
    [DataContract]
    public class ProgramMembership : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ProgramMembership";

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber")]
        public string MembershipNumber { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member")]
        public object Member { get; protected set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [IgnoreDataMember]
        public Person MemberPerson
        {
            get => this.Member as Person;
            set => this.Member = value;
        }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [IgnoreDataMember]
        public Organization MemberOrganization
        {
            get => this.Member as Organization;
            set => this.Member = value;
        }

        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        [DataMember(Name = "hostingOrganization")]
        public Organization HostingOrganization { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName")]
        public string ProgramName { get; set; }
    }
}
