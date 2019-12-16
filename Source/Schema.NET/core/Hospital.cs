namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hospital.
    /// </summary>
    public partial interface IHospital : ICivicStructureAndEmergencyServiceAndMedicalOrganization
    {
        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }
    }

    /// <summary>
    /// A hospital.
    /// </summary>
    [DataContract]
    public partial class Hospital : CivicStructureAndEmergencyServiceAndMedicalOrganization, IHospital, IEquatable<Hospital>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Hospital";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }

        /// <inheritdoc/>
        public bool Equals(Hospital other)
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
                this.AvailableService == other.AvailableService &&
                this.MedicalSpecialty == other.MedicalSpecialty &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Hospital);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AvailableService)
            .And(this.MedicalSpecialty)
            .And(base.GetHashCode());
    }
}
