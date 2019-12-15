namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    public partial interface IGovernmentOrganization : IOrganization
    {
    }

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    [DataContract]
    public partial class GovernmentOrganization : Organization, IGovernmentOrganization, IEquatable<GovernmentOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentOrganization";

        /// <inheritdoc/>
        public bool Equals(GovernmentOrganization other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as GovernmentOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
