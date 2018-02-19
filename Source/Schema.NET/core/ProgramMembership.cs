using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    [DataContract]
    public partial class ProgramMembership : Intangible
    {
        public interface IMember : IWrapper { }
        public interface IMember<T> : IMember { new T Data { get; set; } }
        public class MemberOrganization : IMember<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public MemberOrganization () { }
            public MemberOrganization (Organization data) { Data = data; }
            public static implicit operator MemberOrganization (Organization data) { return new MemberOrganization (data); }
        }

        public class MemberPerson : IMember<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public MemberPerson () { }
            public MemberPerson (Person data) { Data = data; }
            public static implicit operator MemberPerson (Person data) { return new MemberPerson (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? HostingOrganization { get; set; } 

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMember>? Member { get; set; } //Organization, Person

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [DataMember(Name = "membershipNumber", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MembershipNumber { get; set; } 

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [DataMember(Name = "programName", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProgramName { get; set; } 
    }
}
