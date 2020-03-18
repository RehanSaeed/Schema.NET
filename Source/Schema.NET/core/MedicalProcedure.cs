namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    public partial interface IMedicalProcedure : IMedicalEntity
    {
        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Typical or recommended followup care after the procedure is performed.
        /// </summary>
        OneOrMany<string> Followup { get; set; }

        /// <summary>
        /// How the procedure is performed.
        /// </summary>
        OneOrMany<string> HowPerformed { get; set; }

        /// <summary>
        /// Typical preparation that a patient must undergo before having the procedure performed.
        /// </summary>
        Values<IMedicalEntity, string> Preparation { get; set; }

        /// <summary>
        /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
        /// </summary>
        OneOrMany<MedicalProcedureType?> ProcedureType { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }
    }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    [DataContract]
    public partial class MedicalProcedure : MedicalEntity, IMedicalProcedure, IEquatable<MedicalProcedure>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalProcedure";

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Typical or recommended followup care after the procedure is performed.
        /// </summary>
        [DataMember(Name = "followup", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Followup { get; set; }

        /// <summary>
        /// How the procedure is performed.
        /// </summary>
        [DataMember(Name = "howPerformed", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HowPerformed { get; set; }

        /// <summary>
        /// Typical preparation that a patient must undergo before having the procedure performed.
        /// </summary>
        [DataMember(Name = "preparation", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalEntity, string> Preparation { get; set; }

        /// <summary>
        /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
        /// </summary>
        [DataMember(Name = "procedureType", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalProcedureType?> ProcedureType { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalProcedure other)
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
                this.BodyLocation == other.BodyLocation &&
                this.Followup == other.Followup &&
                this.HowPerformed == other.HowPerformed &&
                this.Preparation == other.Preparation &&
                this.ProcedureType == other.ProcedureType &&
                this.Status == other.Status &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalProcedure);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BodyLocation)
            .And(this.Followup)
            .And(this.HowPerformed)
            .And(this.Preparation)
            .And(this.ProcedureType)
            .And(this.Status)
            .And(base.GetHashCode());
    }
}
