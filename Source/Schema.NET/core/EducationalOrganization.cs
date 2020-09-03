namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An educational organization.
    /// </summary>
    public partial interface IEducationalOrganization : ICivicStructureAndOrganization
    {
    }

    /// <summary>
    /// An educational organization.
    /// </summary>
    [DataContract]
    public partial class EducationalOrganization : CivicStructureAndOrganization, IEducationalOrganization, IEquatable<EducationalOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalOrganization";

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Alumni { get; set; }

        /// <inheritdoc/>
        public bool Equals(EducationalOrganization other)
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
                this.Alumni == other.Alumni &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EducationalOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Alumni)
            .And(base.GetHashCode());
    }
}
