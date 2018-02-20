namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    [DataContract]
    public partial class DigitalDocumentPermission : Intangible
    {
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
        public Values<Audience, ContactPoint, Organization, Person>? Grantee { get; set; }

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        [DataMember(Name = "permissionType", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DigitalDocumentPermissionType?>? PermissionType { get; set; }
    }
}
