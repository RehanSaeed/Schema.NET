namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical trial is a type of medical study that uses scientific process used to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// </summary>
    public partial interface IMedicalTrial : IMedicalStudy
    {
        /// <summary>
        /// The phase of the clinical trial.
        /// </summary>
        OneOrMany<string>? Phase { get; set; }

        /// <summary>
        /// Specifics about the trial design (enumerated).
        /// </summary>
        OneOrMany<MedicalTrialDesign?>? TrialDesign { get; set; }
    }

    /// <summary>
    /// A medical trial is a type of medical study that uses scientific process used to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// </summary>
    [DataContract]
    public partial class MedicalTrial : MedicalStudy, IMedicalTrial
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTrial";

        /// <summary>
        /// The phase of the clinical trial.
        /// </summary>
        [DataMember(Name = "phase", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Phase { get; set; }

        /// <summary>
        /// Specifics about the trial design (enumerated).
        /// </summary>
        [DataMember(Name = "trialDesign", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalTrialDesign?>? TrialDesign { get; set; }
    }
}
