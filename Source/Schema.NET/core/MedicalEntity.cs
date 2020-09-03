namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    public partial interface IMedicalEntity : IThing
    {
        /// <summary>
        /// A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
        /// </summary>
        OneOrMany<IMedicalCode> Code { get; set; }

        /// <summary>
        /// A medical guideline related to this entity.
        /// </summary>
        OneOrMany<IMedicalGuideline> Guideline { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        Values<IDrugLegalStatus, MedicalEnumeration?, string> LegalStatus { get; set; }

        /// <summary>
        /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        /// </summary>
        OneOrMany<MedicineSystem?> MedicineSystem { get; set; }

        /// <summary>
        /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        /// </summary>
        OneOrMany<IOrganization> RecognizingAuthority { get; set; }

        /// <summary>
        /// If applicable, a medical specialty in which this entity is relevant.
        /// </summary>
        OneOrMany<MedicalSpecialty?> RelevantSpecialty { get; set; }

        /// <summary>
        /// A medical study or trial related to this entity.
        /// </summary>
        OneOrMany<IMedicalStudy> Study { get; set; }
    }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    [DataContract]
    public partial class MedicalEntity : Thing, IMedicalEntity, IEquatable<MedicalEntity>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalEntity";

        /// <summary>
        /// A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
        /// </summary>
        [DataMember(Name = "code", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCode> Code { get; set; }

        /// <summary>
        /// A medical guideline related to this entity.
        /// </summary>
        [DataMember(Name = "guideline", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalGuideline> Guideline { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IDrugLegalStatus, MedicalEnumeration?, string> LegalStatus { get; set; }

        /// <summary>
        /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        /// </summary>
        [DataMember(Name = "medicineSystem", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicineSystem?> MedicineSystem { get; set; }

        /// <summary>
        /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        /// </summary>
        [DataMember(Name = "recognizingAuthority", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> RecognizingAuthority { get; set; }

        /// <summary>
        /// If applicable, a medical specialty in which this entity is relevant.
        /// </summary>
        [DataMember(Name = "relevantSpecialty", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalSpecialty?> RelevantSpecialty { get; set; }

        /// <summary>
        /// A medical study or trial related to this entity.
        /// </summary>
        [DataMember(Name = "study", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalStudy> Study { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalEntity other)
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
                this.Code == other.Code &&
                this.Guideline == other.Guideline &&
                this.LegalStatus == other.LegalStatus &&
                this.MedicineSystem == other.MedicineSystem &&
                this.RecognizingAuthority == other.RecognizingAuthority &&
                this.RelevantSpecialty == other.RelevantSpecialty &&
                this.Study == other.Study &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalEntity);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Code)
            .And(this.Guideline)
            .And(this.LegalStatus)
            .And(this.MedicineSystem)
            .And(this.RecognizingAuthority)
            .And(this.RelevantSpecialty)
            .And(this.Study)
            .And(base.GetHashCode());
    }
}
