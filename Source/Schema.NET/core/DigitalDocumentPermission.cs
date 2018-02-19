using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    [DataContract]
    public partial class DigitalDocumentPermission : Intangible
    {
        public interface IGrantee : IWrapper { }
        public interface IGrantee<T> : IGrantee { new T Data { get; set; } }
        public class GranteeAudience : IGrantee<Audience>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Audience) value; } }
            public virtual Audience Data { get; set; }
            public GranteeAudience () { }
            public GranteeAudience (Audience data) { Data = data; }
            public static implicit operator GranteeAudience (Audience data) { return new GranteeAudience (data); }
        }

        public class GranteeContactPoint : IGrantee<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public GranteeContactPoint () { }
            public GranteeContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator GranteeContactPoint (ContactPoint data) { return new GranteeContactPoint (data); }
        }

        public class GranteeOrganization : IGrantee<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public GranteeOrganization () { }
            public GranteeOrganization (Organization data) { Data = data; }
            public static implicit operator GranteeOrganization (Organization data) { return new GranteeOrganization (data); }
        }

        public class GranteePerson : IGrantee<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public GranteePerson () { }
            public GranteePerson (Person data) { Data = data; }
            public static implicit operator GranteePerson (Person data) { return new GranteePerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DigitalDocumentPermission";

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [DataMember(Name = "grantee", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGrantee>? Grantee { get; set; } //Audience, ContactPoint, Organization, Person

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        [DataMember(Name = "permissionType", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DigitalDocumentPermissionType>? PermissionType { get; set; } 
    }
}
