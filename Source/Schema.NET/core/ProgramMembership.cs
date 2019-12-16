namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    public partial interface IProgramMembership : IIntangible
    {
        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        OneOrMany<IOrganization> HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        OneOrMany<string> MembershipNumber { get; set; }

        /// <summary>
        /// The number of membership points earned by the member. If necessary, the unitText can be used to express the units the points are issued in. (e.g. stars, miles, etc.)
        /// </summary>
        Values<double?, IQuantitativeValue> MembershipPointsEarned { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        OneOrMany<string> ProgramName { get; set; }
    }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    [DataContract]
    public partial class ProgramMembership : Intangible, IProgramMembership, IEquatable<ProgramMembership>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MembershipNumber { get; set; }

        /// <summary>
        /// The number of membership points earned by the member. If necessary, the unitText can be used to express the units the points are issued in. (e.g. stars, miles, etc.)
        /// </summary>
        [DataMember(Name = "membershipPointsEarned", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> MembershipPointsEarned { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProgramName { get; set; }

        /// <inheritdoc/>
        public bool Equals(ProgramMembership other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.HostingOrganization == other.HostingOrganization &&
                this.Member == other.Member &&
                this.MembershipNumber == other.MembershipNumber &&
                this.MembershipPointsEarned == other.MembershipPointsEarned &&
                this.ProgramName == other.ProgramName &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ProgramMembership);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HostingOrganization)
            .And(this.Member)
            .And(this.MembershipNumber)
            .And(this.MembershipPointsEarned)
            .And(this.ProgramName)
            .And(base.GetHashCode());
    }
}
