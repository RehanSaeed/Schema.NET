namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
    [DataContract]
    public partial class MedicalCondition : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalCondition";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [DataMember(Name = "associatedAnatomy", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure, AnatomicalSystem, SuperficialAnatomy>? AssociatedAnatomy { get; set; }

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        [DataMember(Name = "cause", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalCause>? Cause { get; set; }

        /// <summary>
        /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
        /// </summary>
        [DataMember(Name = "differentialDiagnosis", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DDxElement>? DifferentialDiagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [DataMember(Name = "drug", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Drug>? Drug { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [DataMember(Name = "epidemiology", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Epidemiology { get; set; }

        /// <summary>
        /// The likely outcome in either the short term or long term of the medical condition.
        /// </summary>
        [DataMember(Name = "expectedPrognosis", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ExpectedPrognosis { get; set; }

        /// <summary>
        /// The expected progression of the condition if it is not treated and allowed to progress naturally.
        /// </summary>
        [DataMember(Name = "naturalProgression", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? NaturalProgression { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [DataMember(Name = "pathophysiology", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pathophysiology { get; set; }

        /// <summary>
        /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
        /// </summary>
        [DataMember(Name = "possibleComplication", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PossibleComplication { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        [DataMember(Name = "possibleTreatment", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalTherapy>? PossibleTreatment { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
        /// </summary>
        [DataMember(Name = "primaryPrevention", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTherapy>? PrimaryPrevention { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
        /// </summary>
        [DataMember(Name = "riskFactor", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalRiskFactor>? RiskFactor { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
        /// </summary>
        [DataMember(Name = "secondaryPrevention", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTherapy>? SecondaryPrevention { get; set; }

        /// <summary>
        /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
        /// </summary>
        [DataMember(Name = "signOrSymptom", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalSignOrSymptom>? SignOrSymptom { get; set; }

        /// <summary>
        /// The stage of the condition, if applicable.
        /// </summary>
        [DataMember(Name = "stage", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalConditionStage>? Stage { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EventStatusType?, MedicalStudyStatus?, string>? Status { get; set; }

        /// <summary>
        /// A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.
        /// </summary>
        [DataMember(Name = "subtype", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Subtype { get; set; }

        /// <summary>
        /// A medical test typically performed given this condition.
        /// </summary>
        [DataMember(Name = "typicalTest", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTest>? TypicalTest { get; set; }
    }
}
