namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
    public partial interface IMedicalTherapy : ITherapeuticProcedure
    {
        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        Values<IMedicalContraindication, string>? Contraindication { get; set; }

        /// <summary>
        /// A therapy that duplicates or overlaps this one.
        /// </summary>
        OneOrMany<IMedicalTherapy> DuplicateTherapy { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        OneOrMany<IMedicalEntity> SeriousAdverseOutcome { get; set; }
    }

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
    [DataContract]
    public partial class MedicalTherapy : TherapeuticProcedure, IMedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTherapy";

        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        [DataMember(Name = "contraindication", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalContraindication, string>? Contraindication { get; set; }

        /// <summary>
        /// A therapy that duplicates or overlaps this one.
        /// </summary>
        [DataMember(Name = "duplicateTherapy", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy> DuplicateTherapy { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        [DataMember(Name = "seriousAdverseOutcome", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> SeriousAdverseOutcome { get; set; }
    }
}
