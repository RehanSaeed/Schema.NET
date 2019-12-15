namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
    public partial interface IMedicalOrganization : IOrganization
    {
        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        OneOrMany<string> HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        OneOrMany<bool?> IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }
    }

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
    [DataContract]
    public partial class MedicalOrganization : Organization, IMedicalOrganization, IEquatable<MedicalOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalOrganization other)
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
                this.HealthPlanNetworkId == other.HealthPlanNetworkId &&
                this.IsAcceptingNewPatients == other.IsAcceptingNewPatients &&
                this.MedicalSpecialty == other.MedicalSpecialty &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HealthPlanNetworkId)
            .And(this.IsAcceptingNewPatients)
            .And(this.MedicalSpecialty)
            .And(base.GetHashCode());
    }
}
