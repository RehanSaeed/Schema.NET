namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A doctor's office.
    /// </summary>
    public partial interface IPhysician : IMedicalBusinessAndMedicalOrganization
    {
        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        OneOrMany<IHospital> HospitalAffiliation { get; set; }
    }

    /// <summary>
    /// A doctor's office.
    /// </summary>
    [DataContract]
    public partial class Physician : MedicalBusinessAndMedicalOrganization, IPhysician, IEquatable<Physician>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Physician";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [DataMember(Name = "hospitalAffiliation", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IHospital> HospitalAffiliation { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }

        /// <inheritdoc/>
        public bool Equals(Physician other)
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
                this.HospitalAffiliation == other.HospitalAffiliation &&
                this.MedicalSpecialty == other.MedicalSpecialty &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Physician);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AvailableService)
            .And(this.HospitalAffiliation)
            .And(this.MedicalSpecialty)
            .And(base.GetHashCode());
    }
}
