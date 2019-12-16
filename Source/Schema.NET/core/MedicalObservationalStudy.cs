namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An observational study is a type of medical study that attempts to infer the possible effect of a treatment through observation of a cohort of subjects over a period of time. In an observational study, the assignment of subjects into treatment groups versus control groups is outside the control of the investigator. This is in contrast with controlled studies, such as the randomized controlled trials represented by MedicalTrial, where each subject is randomly assigned to a treatment group or a control group before the start of the treatment.
    /// </summary>
    public partial interface IMedicalObservationalStudy : IMedicalStudy
    {
        /// <summary>
        /// Specifics about the observational study design (enumerated).
        /// </summary>
        OneOrMany<MedicalObservationalStudyDesign?> StudyDesign { get; set; }
    }

    /// <summary>
    /// An observational study is a type of medical study that attempts to infer the possible effect of a treatment through observation of a cohort of subjects over a period of time. In an observational study, the assignment of subjects into treatment groups versus control groups is outside the control of the investigator. This is in contrast with controlled studies, such as the randomized controlled trials represented by MedicalTrial, where each subject is randomly assigned to a treatment group or a control group before the start of the treatment.
    /// </summary>
    [DataContract]
    public partial class MedicalObservationalStudy : MedicalStudy, IMedicalObservationalStudy, IEquatable<MedicalObservationalStudy>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalObservationalStudy";

        /// <summary>
        /// Specifics about the observational study design (enumerated).
        /// </summary>
        [DataMember(Name = "studyDesign", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalObservationalStudyDesign?> StudyDesign { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalObservationalStudy other)
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
                this.StudyDesign == other.StudyDesign &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalObservationalStudy);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.StudyDesign)
            .And(base.GetHashCode());
    }
}
