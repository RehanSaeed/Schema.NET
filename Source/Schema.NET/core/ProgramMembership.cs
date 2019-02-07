namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    [DataContract]
    public partial class ProgramMembership : Intangible
    {
        public interface IHostingOrganization : IValue {}
        public interface IHostingOrganization<T> : IHostingOrganization { new T Value { get; } }
        public class OneOrManyHostingOrganization : OneOrMany<IHostingOrganization>
        {
            public OneOrManyHostingOrganization(IHostingOrganization item) : base(item) { }
            public OneOrManyHostingOrganization(IEnumerable<IHostingOrganization> items) : base(items) { }
            public static implicit operator OneOrManyHostingOrganization (Organization value) { return new OneOrManyHostingOrganization (new HostingOrganizationOrganization (value)); }
            public static implicit operator OneOrManyHostingOrganization (Organization[] values) { return new OneOrManyHostingOrganization (values.Select(v => (IHostingOrganization) new HostingOrganizationOrganization (v))); }
            public static implicit operator OneOrManyHostingOrganization (List<Organization> values) { return new OneOrManyHostingOrganization (values.Select(v => (IHostingOrganization) new HostingOrganizationOrganization (v))); }
        }
        public struct HostingOrganizationOrganization : IHostingOrganization<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public HostingOrganizationOrganization (Organization value) { Value = value; }
            public static implicit operator HostingOrganizationOrganization (Organization value) { return new HostingOrganizationOrganization (value); }
        }

        public interface IMember : IValue {}
        public interface IMember<T> : IMember { new T Value { get; } }
        public class OneOrManyMember : OneOrMany<IMember>
        {
            public OneOrManyMember(IMember item) : base(item) { }
            public OneOrManyMember(IEnumerable<IMember> items) : base(items) { }
            public static implicit operator OneOrManyMember (Organization value) { return new OneOrManyMember (new MemberOrganization (value)); }
            public static implicit operator OneOrManyMember (Organization[] values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberOrganization (v))); }
            public static implicit operator OneOrManyMember (List<Organization> values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberOrganization (v))); }
            public static implicit operator OneOrManyMember (Person value) { return new OneOrManyMember (new MemberPerson (value)); }
            public static implicit operator OneOrManyMember (Person[] values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberPerson (v))); }
            public static implicit operator OneOrManyMember (List<Person> values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberPerson (v))); }
        }
        public struct MemberOrganization : IMember<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public MemberOrganization (Organization value) { Value = value; }
            public static implicit operator MemberOrganization (Organization value) { return new MemberOrganization (value); }
        }
        public struct MemberPerson : IMember<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public MemberPerson (Person value) { Value = value; }
            public static implicit operator MemberPerson (Person value) { return new MemberPerson (value); }
        }

        public interface IMembershipNumber : IValue {}
        public interface IMembershipNumber<T> : IMembershipNumber { new T Value { get; } }
        public class OneOrManyMembershipNumber : OneOrMany<IMembershipNumber>
        {
            public OneOrManyMembershipNumber(IMembershipNumber item) : base(item) { }
            public OneOrManyMembershipNumber(IEnumerable<IMembershipNumber> items) : base(items) { }
            public static implicit operator OneOrManyMembershipNumber (string value) { return new OneOrManyMembershipNumber (new MembershipNumberstring (value)); }
            public static implicit operator OneOrManyMembershipNumber (string[] values) { return new OneOrManyMembershipNumber (values.Select(v => (IMembershipNumber) new MembershipNumberstring (v))); }
            public static implicit operator OneOrManyMembershipNumber (List<string> values) { return new OneOrManyMembershipNumber (values.Select(v => (IMembershipNumber) new MembershipNumberstring (v))); }
        }
        public struct MembershipNumberstring : IMembershipNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MembershipNumberstring (string value) { Value = value; }
            public static implicit operator MembershipNumberstring (string value) { return new MembershipNumberstring (value); }
        }

        public interface IProgramName : IValue {}
        public interface IProgramName<T> : IProgramName { new T Value { get; } }
        public class OneOrManyProgramName : OneOrMany<IProgramName>
        {
            public OneOrManyProgramName(IProgramName item) : base(item) { }
            public OneOrManyProgramName(IEnumerable<IProgramName> items) : base(items) { }
            public static implicit operator OneOrManyProgramName (string value) { return new OneOrManyProgramName (new ProgramNamestring (value)); }
            public static implicit operator OneOrManyProgramName (string[] values) { return new OneOrManyProgramName (values.Select(v => (IProgramName) new ProgramNamestring (v))); }
            public static implicit operator OneOrManyProgramName (List<string> values) { return new OneOrManyProgramName (values.Select(v => (IProgramName) new ProgramNamestring (v))); }
        }
        public struct ProgramNamestring : IProgramName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProgramNamestring (string value) { Value = value; }
            public static implicit operator ProgramNamestring (string value) { return new ProgramNamestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProgramMembership";

        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        [DataMember(Name = "hostingOrganization", Order = 206)]
        public OneOrManyHostingOrganization HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 207)]
        public OneOrManyMember Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber", Order = 208)]
        public OneOrManyMembershipNumber MembershipNumber { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName", Order = 209)]
        public OneOrManyProgramName ProgramName { get; set; }
    }
}
