namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical study is an umbrella type covering all kinds of research studies relating to human medicine or health, including observational studies and interventional trials and registries, randomized, controlled or not. When the specific type of study is known, use one of the extensions of this type, such as MedicalTrial or MedicalObservationalStudy. Also, note that this type should be used to mark up data that describes the study itself; to tag an article that publishes the results of a study, use MedicalScholarlyArticle. Note: use the code property of MedicalEntity to store study IDs, e.g. clinicaltrials.gov ID.
    /// </summary>
    public partial interface IMedicalStudy : IMedicalEntity
    {
        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }

        /// <summary>
        /// The location in which the study is taking/took place.
        /// </summary>
        OneOrMany<IAdministrativeArea> StudyLocation { get; set; }

        /// <summary>
        /// A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.
        /// </summary>
        OneOrMany<IMedicalEntity> StudySubject { get; set; }
    }

    /// <summary>
    /// A medical study is an umbrella type covering all kinds of research studies relating to human medicine or health, including observational studies and interventional trials and registries, randomized, controlled or not. When the specific type of study is known, use one of the extensions of this type, such as MedicalTrial or MedicalObservationalStudy. Also, note that this type should be used to mark up data that describes the study itself; to tag an article that publishes the results of a study, use MedicalScholarlyArticle. Note: use the code property of MedicalEntity to store study IDs, e.g. clinicaltrials.gov ID.
    /// </summary>
    [DataContract]
    public partial class MedicalStudy : MedicalEntity, IMedicalStudy, IEquatable<MedicalStudy>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalStudy";

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [DataMember(Name = "healthCondition", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }

        /// <summary>
        /// The location in which the study is taking/took place.
        /// </summary>
        [DataMember(Name = "studyLocation", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> StudyLocation { get; set; }

        /// <summary>
        /// A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.
        /// </summary>
        [DataMember(Name = "studySubject", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> StudySubject { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalStudy other)
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
                this.HealthCondition == other.HealthCondition &&
                this.Sponsor == other.Sponsor &&
                this.Status == other.Status &&
                this.StudyLocation == other.StudyLocation &&
                this.StudySubject == other.StudySubject &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalStudy);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HealthCondition)
            .And(this.Sponsor)
            .And(this.Status)
            .And(this.StudyLocation)
            .And(this.StudySubject)
            .And(base.GetHashCode());
    }
}
