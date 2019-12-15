namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    public partial interface IMedicalBusinessAndMedicalOrganization : IMedicalBusiness, IMedicalOrganization
    {
    }

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class MedicalBusinessAndMedicalOrganization : LocalBusinessAndOrganization, IMedicalBusinessAndMedicalOrganization, IEquatable<MedicalBusinessAndMedicalOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalBusinessAndMedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalBusinessAndMedicalOrganization other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalBusinessAndMedicalOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HealthPlanNetworkId)
            .And(this.IsAcceptingNewPatients)
            .And(this.MedicalSpecialty)
            .And(base.GetHashCode());
    }
}
