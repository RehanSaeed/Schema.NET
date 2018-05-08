namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
    public partial interface IMedicalDevice : IMedicalEntity
    {
        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        OneOrMany<IMedicalEntity>? AdverseOutcome { get; set; }

        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        Values<IMedicalContraindication, string>? Contraindication { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        OneOrMany<IMedicalIndication>? Indication { get; set; }

        /// <summary>
        /// A description of the postoperative procedures, care, and/or followups for this device.
        /// </summary>
        OneOrMany<string>? PostOp { get; set; }

        /// <summary>
        /// A description of the workup, testing, and other preparations required before implanting this device.
        /// </summary>
        OneOrMany<string>? PreOp { get; set; }

        /// <summary>
        /// A description of the procedure involved in setting up, using, and/or installing the device.
        /// </summary>
        OneOrMany<string>? Procedure { get; set; }

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing>? Purpose { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        OneOrMany<IMedicalEntity>? SeriousAdverseOutcome { get; set; }
    }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
    [DataContract]
    public partial class MedicalDevice : MedicalEntity, IMedicalDevice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalDevice";

        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        [DataMember(Name = "adverseOutcome", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMedicalEntity>? AdverseOutcome { get; set; }

        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        [DataMember(Name = "contraindication", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMedicalContraindication, string>? Contraindication { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMedicalIndication>? Indication { get; set; }

        /// <summary>
        /// A description of the postoperative procedures, care, and/or followups for this device.
        /// </summary>
        [DataMember(Name = "postOp", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PostOp { get; set; }

        /// <summary>
        /// A description of the workup, testing, and other preparations required before implanting this device.
        /// </summary>
        [DataMember(Name = "preOp", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PreOp { get; set; }

        /// <summary>
        /// A description of the procedure involved in setting up, using, and/or installing the device.
        /// </summary>
        [DataMember(Name = "procedure", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Procedure { get; set; }

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalDevicePurpose?, IThing>? Purpose { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        [DataMember(Name = "seriousAdverseOutcome", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMedicalEntity>? SeriousAdverseOutcome { get; set; }
    }
}
