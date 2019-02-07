namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    [DataContract]
    public partial class DigitalDocumentPermission : Intangible
    {
        public interface IGrantee : IValue {}
        public interface IGrantee<T> : IGrantee { new T Value { get; } }
        public class OneOrManyGrantee : OneOrMany<IGrantee>
        {
            public OneOrManyGrantee(IGrantee item) : base(item) { }
            public OneOrManyGrantee(IEnumerable<IGrantee> items) : base(items) { }
            public static implicit operator OneOrManyGrantee (Audience value) { return new OneOrManyGrantee (new GranteeAudience (value)); }
            public static implicit operator OneOrManyGrantee (Audience[] values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeAudience (v))); }
            public static implicit operator OneOrManyGrantee (List<Audience> values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeAudience (v))); }
            public static implicit operator OneOrManyGrantee (ContactPoint value) { return new OneOrManyGrantee (new GranteeContactPoint (value)); }
            public static implicit operator OneOrManyGrantee (ContactPoint[] values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeContactPoint (v))); }
            public static implicit operator OneOrManyGrantee (List<ContactPoint> values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeContactPoint (v))); }
            public static implicit operator OneOrManyGrantee (Organization value) { return new OneOrManyGrantee (new GranteeOrganization (value)); }
            public static implicit operator OneOrManyGrantee (Organization[] values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeOrganization (v))); }
            public static implicit operator OneOrManyGrantee (List<Organization> values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteeOrganization (v))); }
            public static implicit operator OneOrManyGrantee (Person value) { return new OneOrManyGrantee (new GranteePerson (value)); }
            public static implicit operator OneOrManyGrantee (Person[] values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteePerson (v))); }
            public static implicit operator OneOrManyGrantee (List<Person> values) { return new OneOrManyGrantee (values.Select(v => (IGrantee) new GranteePerson (v))); }
        }
        public struct GranteeAudience : IGrantee<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public GranteeAudience (Audience value) { Value = value; }
            public static implicit operator GranteeAudience (Audience value) { return new GranteeAudience (value); }
        }
        public struct GranteeContactPoint : IGrantee<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public GranteeContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator GranteeContactPoint (ContactPoint value) { return new GranteeContactPoint (value); }
        }
        public struct GranteeOrganization : IGrantee<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public GranteeOrganization (Organization value) { Value = value; }
            public static implicit operator GranteeOrganization (Organization value) { return new GranteeOrganization (value); }
        }
        public struct GranteePerson : IGrantee<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public GranteePerson (Person value) { Value = value; }
            public static implicit operator GranteePerson (Person value) { return new GranteePerson (value); }
        }

        public interface IPermissionType : IValue {}
        public interface IPermissionType<T> : IPermissionType { new T Value { get; } }
        public class OneOrManyPermissionType : OneOrMany<IPermissionType>
        {
            public OneOrManyPermissionType(IPermissionType item) : base(item) { }
            public OneOrManyPermissionType(IEnumerable<IPermissionType> items) : base(items) { }
            public static implicit operator OneOrManyPermissionType (DigitalDocumentPermissionType value) { return new OneOrManyPermissionType (new PermissionTypeDigitalDocumentPermissionType (value)); }
            public static implicit operator OneOrManyPermissionType (DigitalDocumentPermissionType[] values) { return new OneOrManyPermissionType (values.Select(v => (IPermissionType) new PermissionTypeDigitalDocumentPermissionType (v))); }
            public static implicit operator OneOrManyPermissionType (List<DigitalDocumentPermissionType> values) { return new OneOrManyPermissionType (values.Select(v => (IPermissionType) new PermissionTypeDigitalDocumentPermissionType (v))); }
        }
        public struct PermissionTypeDigitalDocumentPermissionType : IPermissionType<DigitalDocumentPermissionType>
        {
            object IValue.Value => this.Value;
            public DigitalDocumentPermissionType Value { get; }
            public PermissionTypeDigitalDocumentPermissionType (DigitalDocumentPermissionType value) { Value = value; }
            public static implicit operator PermissionTypeDigitalDocumentPermissionType (DigitalDocumentPermissionType value) { return new PermissionTypeDigitalDocumentPermissionType (value); }
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
        public OneOrManyGrantee Grantee { get; set; }

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        [DataMember(Name = "permissionType", Order = 207)]
        public OneOrManyPermissionType PermissionType { get; set; }
    }
}
