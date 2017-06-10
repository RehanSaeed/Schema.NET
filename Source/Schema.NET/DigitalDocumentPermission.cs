namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    [DataContract]
    public class DigitalDocumentPermission : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DigitalDocumentPermission";

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [DataMember(Name = "grantee", Order = 2)]
        public object Grantee { get; protected set; }

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [IgnoreDataMember]
        public Audience GranteeAudience
        {
            get => this.Grantee as Audience;
            set => this.Grantee = value;
        }

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [IgnoreDataMember]
        public ContactPoint GranteeContactPoint
        {
            get => this.Grantee as ContactPoint;
            set => this.Grantee = value;
        }

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [IgnoreDataMember]
        public Organization GranteeOrganization
        {
            get => this.Grantee as Organization;
            set => this.Grantee = value;
        }

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [IgnoreDataMember]
        public Person GranteePerson
        {
            get => this.Grantee as Person;
            set => this.Grantee = value;
        }

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        [DataMember(Name = "permissionType", Order = 3)]
        public DigitalDocumentPermissionType? PermissionType { get; set; }
    }
}
