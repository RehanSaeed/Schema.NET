namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
    public partial interface IMedicalClinic : IMedicalBusinessAndMedicalOrganization
    {
        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }
    }

    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
    [DataContract]
    public partial class MedicalClinic : MedicalBusinessAndMedicalOrganization, IMedicalClinic, IEquatable<MedicalClinic>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalClinic";

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
        public bool Equals(MedicalClinic other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalClinic);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AvailableService)
            .And(this.MedicalSpecialty)
            .And(base.GetHashCode());
    }
}
