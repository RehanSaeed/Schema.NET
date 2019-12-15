namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    public partial interface IOrganizationRole : IRole
    {
        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        OneOrMany<double?> NumberedPosition { get; set; }
    }

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    [DataContract]
    public partial class OrganizationRole : Role, IOrganizationRole, IEquatable<OrganizationRole>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationRole";

        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        [DataMember(Name = "numberedPosition", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> NumberedPosition { get; set; }

        /// <inheritdoc/>
        public bool Equals(OrganizationRole other)
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
                this.NumberedPosition == other.NumberedPosition &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as OrganizationRole);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberedPosition)
            .And(base.GetHashCode());
    }
}
